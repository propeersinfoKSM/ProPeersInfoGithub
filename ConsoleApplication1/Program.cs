using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		public void test()
		{


			FileStream fs = new FileStream("D:\\Sample.txt", FileMode.Open, FileAccess.Read);
			//StreamReader sr=new StreamReader(fs);
			BinaryReader br = new BinaryReader(fs);
			byte[] info = br.ReadBytes((int)fs.Length);
																																							 
			br.Close();
			fs.Close();

			FileStream fs2 = new FileStream("D:\\Test.txt", FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs2);
			bw.Write(info);
			bw.Close();
			fs2.Close();

		}
		static void Main(string[] args)
		{

			Program p = new Program();
		}


	}
}
