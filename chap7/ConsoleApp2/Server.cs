using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp2 { 
    class Server {
        static void Main(string[] args) {
            NetworkStream stream = null;
            TcpListener tcpListener = null;
            Socket clientsoket = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try  {
                //IP주소를 나타내는 객체를 생성,TcpListener를 생성시 인자로 사용      
                //IPAddress ipAd = IPAddress.Parse("127.0.0.1");                 // 로컬          
                IPAddress ipAd = IPAddress.Parse("192.168.0.223");

                //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다. 
                tcpListener = new TcpListener(ipAd, 5001);          // 서버소켓띄움
                tcpListener.Start();

                //Client의 접속이 올때 까지 Block 되는 부분, 대개 이부분을 Thread로 만들어 보내 버린다.
                //백그라운드 Thread에 처리를 맡긴다. 
                //클라이언트 요청을 기다리며 대기상태. 요청이 들어오면 요청큐에 쌓임.
                clientsoket = tcpListener.AcceptSocket();
                // AcceptSocket 하면 socket이 만들어짐. 데이터 주고받는것은 소켓끼리하는것.

                //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다. 
                stream = new NetworkStream(clientsoket);
                Encoding encode = Encoding.GetEncoding("utf-8");
                reader = new StreamReader(stream, encode);      // 서버
                writer = new StreamWriter(stream, encode) { AutoFlush = true };     // 에코통신
                // StreamReader : 한라인씩 읽어들이기 위한 클래스

                while (true) {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);

                    writer.WriteLine(str);  // 에코통신
                }
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            } finally {
                clientsoket.Close();
            }
        }
    }
}
