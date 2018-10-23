using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp3 {
    class ClientHadler {
        Socket socket = null;
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null;

        public ClientHadler(Socket socket) {
            this.socket = socket;
            Server.list.Add(socket);
        }

        public void chat() {
            Encoding encode = Encoding.GetEncoding("euc-kr");
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream, encode);
            try {
                while(true) {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);

                    // ArrayList에 보관된 모든 클라이언트 처리 소켓만큼 현재 접속한 모든 클라이언트에게 글을 씀
                    foreach(Socket s in Server.list) {
                        //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다. 
                        stream = new NetworkStream(s);
                        writer = new StreamWriter(stream, encode) { AutoFlush = true };
                        writer.WriteLine(str);
                    }
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
            finally {
                Server.list.Remove(socket);
                socket.Close();
                socket = null;
            }
        }
    }

    class Server {
        // 클라이언트가 다수 접속하므로 서버가 AcceptSocket 으로 생성한
        // 클라이언트 상대하는 소켓을 ArrayList등에 보관하고 글을 쓸 때
        // 현재 접속한 클라이언트 모두에게 글을 보내야 한다.
        public static List<Socket> list = new List<Socket>();

        public static void Main() {
            TcpListener tcpListener = null;
            Socket clientsocket = null;

            try {
                //IP주소를 나타내는 객체를 생성,TcpListener를 생성시 인자로 사용
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");

                //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다. 
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                //Client의 접속이 올때 까지 Block 되는 부분, 대개 이부분을 Thread로 만들어 보내 버린다.
                //백그라운드 Thread에 처리를 맡긴다. 
                while(true) {
                    clientsocket = tcpListener.AcceptSocket();
                    ClientHadler cHandler = new ClientHadler(clientsocket);
                    Thread t = new Thread(new ThreadStart(cHandler.chat));
                    t.Start();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            finally {
                clientsocket.Close();
            }
        }
    }
}
