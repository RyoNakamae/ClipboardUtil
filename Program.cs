using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardUtil
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //クリップボードに貼り付ける文字列
            var setText = "コピー文字列_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            try
            {
                //クリップボードに残っていたらそれを表示させてみる
                if (Clipboard.ContainsText())
                {
                    //文字列データがあるときはこれを取得する
                    //取得できないときは空の文字列（String.Empty）を返す
                    var text = Clipboard.GetText();
                    if (string.IsNullOrEmpty(text)) text = "取得に失敗しました。";

                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("残ってません。");
                }

                //指定文字列をクリップボードに貼り付ける
                Clipboard.SetText(setText);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
