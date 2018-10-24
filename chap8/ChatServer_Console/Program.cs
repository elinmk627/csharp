using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatServer_Console {

    

    delegate void SetTextCallback(string s);
    class MForm : Form {
        NetworkStream stream = null;
        TcpListener tcpListener = null;
        Socket clientsoket = null;
        StreamReader reader = null;



    }



    class MApplication {
        public static void Main() {
            Application.Run(new MForm());
        }
    }
}
