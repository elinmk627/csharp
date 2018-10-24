using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatClient {
    delegate void SetTextCallback(string s);
    public partial class Form1 : Form  {
        public Form1() {
            InitializeComponent();
        }

        TcpClient tcpClient = null;
        NetworkStream ntwStream = null;
        Chat_Class cht_Class = new Chat_Class();
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)  {
            if (cmd_Connect.Text == "Login") {
                return;
            }
            Message_Snd("<" + txt_Name.Text + "> 님께서 접속해제 하셨습니다.", false);
            cht_Class.Chat_Close();
            ntwStream.Close();
            tcpClient.Close();
        }

        private void cmd_Connect_Click(object sender, EventArgs e) {
            if (cmd_Connect.Text == "Login") {
                try {                    
                    IPAddress ipaAddress = IPAddress.Parse(txt_Server_IP.Text);     //IP Address 할당                    
                    tcpClient = new TcpClient();                                                       //TCP Client 선언                   
                    tcpClient.Connect(ipaAddress, 5001);                                        //TCP Client연결                    
                    ntwStream = tcpClient.GetStream();                                          //NetworkStream을 생성                    
                    cht_Class.Chat_Class_Setup(this, ntwStream, this.txt_Chat);      //Stream과 txt_Chat 할당                   
                    Thread thd_Receive = new Thread(new ThreadStart(cht_Class.Chat_Process));    //Thread를 생성하고 Star시킴
                    thd_Receive.Start();
                    Message_Snd("<" + txt_Name.Text + "> 님께서 접속 하셨습니다.", true);
                    cmd_Connect.Text = "Logout";
                }
                catch (System.Exception Err)  {
                    MessageBox.Show("Chatting Server 오류발생 또는 Start 되지 않았거나\n\n" + Err.Message, "Client");
                }
            }
            else {
                Message_Snd("<" + txt_Name.Text + "> 님께서 접속해제 하셨습니다.", false);
                cmd_Connect.Text = "Login";
                cht_Class.Chat_Close();
                ntwStream.Close();
                tcpClient.Close();
            }
        }

        private void txt_Msg_KeyPress(object sender, KeyPressEventArgs e)  {
            if (e.KeyChar == 13) {
                if (cmd_Connect.Text == "Logout") {
                    Message_Snd("<" + txt_Name.Text + "> " + txt_Msg.Text, true);
                }
                txt_Msg.Text = "";
                e.Handled = true;
            }
        }

        //다른 스레드인 Chat_Class의 쓰레드에서 호출하는 함수
        //txt_Chat 텍스트박스는 Chat_Class에서 생성한 것이 아니므로
        //이 메소드를 호출하여 델리게이트를 통하여 서버에서 넘어오는 메시지를 쓴다.
        public void SetText(string text) {
            if (this.txt_Chat.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.txt_Chat.AppendText(text);
            }
        }

        private void Message_Snd(string lstMessage, Boolean Msg) {
            try {
                //보낼 데이터를 읽어 Default 형식의 바이트 스트림으로 변환 해서 전송
                string dataToSend = lstMessage + "\r\n";
                byte[] data = Encoding.Default.GetBytes(dataToSend);
                ntwStream.Write(data, 0, data.Length);
            }
            catch (System.Exception Err) {
                if (Msg == true) {
                    MessageBox.Show("Chatting Server가 오류발생 또는 Start 되지 않았거나\n\n" + Err.Message, "Client");                   
                    cmd_Connect.Text = "Login";
                    cht_Class.Chat_Close();
                    ntwStream.Close();
                    tcpClient.Close();
                }
            }
        }
    }

    public class Chat_Class {        
        private Encoding ecd_Encode = Encoding.GetEncoding("KS_C_5601-1987");       //한글 처리를 위해 Encod 정의       
        private System.Windows.Forms.TextBox txt_Chat;       //글자를 Display할 Object
        private NetworkStream netStream;
        private StreamReader strReader;
        private Form1 form1;

        public void Chat_Class_Setup(Form1 form1, NetworkStream netStream, System.Windows.Forms.TextBox txt_Chat) {            
            this.txt_Chat = txt_Chat;               //TextBox를 할당함.            
            this.netStream = netStream;         //Network Stream을 할당            
            this.strReader = new StreamReader(netStream, ecd_Encode);       //Stream Reader을 생성
            this.form1 = form1;
        }

        public void Chat_Process() {
            while (true) {
                try  {
                    //문자열을 받음
                    string lstMessage = strReader.ReadLine();
                    if (lstMessage != null && lstMessage != "") {                        
                         form1.SetText(lstMessage + "\r\n");        //SetText의 델리게이트를 이용하여 서버에서 넘어오는 메시지를 쓴다.
                        //this.txt_Chat.AppendText(lstMessage + "\r\n");        //직접쓰면 에러발생
                    }
                }
                catch (System.Exception) {
                    break;
                }
            }
        }

        public void Chat_Close() {
            netStream.Close();
            strReader.Close();
        }
    }
}
