using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			var a = new HelloWorld.ClassA();
			a.FuncSimple();
			a.FuncArgInt(2);
            a.FuncArgFloatBoolStr(2.2f, true, "hello");

            HelloWorld.StructA sa = new HelloWorld.StructA();
            sa.X = 1.0f;
            sa.Y = 2.0f;
            sa.Z = 3.0f;
            a.FuncArgStruct(ref sa);

			HelloWorld.ClassB cb = new HelloWorld.ClassB();
			cb.SetValue(100);
			a.FuncArgClass(cb);

			var retBool = a.FuncReturnBool();
			Console.WriteLine(retBool);

			var retStruct = a.FuncReturnStruct();
			Console.WriteLine(string.Format("{0},{1},{2}", retStruct.X, retStruct.Y, retStruct.Z));

            var retSrring = a.FuncReturnString();
            Console.WriteLine(retSrring);

        }
    }
}