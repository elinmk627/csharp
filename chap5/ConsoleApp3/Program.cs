using System;
using System.Linq;

namespace ConsoleApp3 {
    class LynqLetExample {
        static void Main() {
            //문자열 입력시 콤마 다음에는 공백이 없다!
            string[] myFaver = {
                "Apple,Banana,Strawberry",
                "Baseball,Football,Soccur",
                "Programming,Design,Assembly",
            };

            var favorite =
                from m in myFaver
                let favor = m.Split(',')
                from word in favor
                let w = word.ToLower()  //  ToLower : 복사본(word)를 소문자로 변경
                where w[0] == 'a'
                select word;

            foreach(var w in favorite) {
                Console.WriteLine("A로 시작되는 단어 : {0}", w); 
            }
        }
    }
}
