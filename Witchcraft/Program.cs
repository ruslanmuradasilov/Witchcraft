using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Witchcraft
{
	class Program
	{
#nullable enable
		//TODO: add lock, using, record
		[Obsolete("This class is obsolete; use class CHUDO_YUDO instead")]
		protected internal readonly ref partial struct CHUDO<T, U>
			where T : unmanaged, IQbservable<T?>?
			where U : new()
		{
			public abstract record Person(string FirstName, string LastName);
			private static nint _fantastika;
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public unsafe nint Fantastika 
			{
				readonly get => _fantastika;
				internal init => _fantastika = value;
			}

			public static async Task<Task<(U, T)>> GetMagicTask(nuint arg)
			{
				return await @private(arg);
			}

			private static async Task<Task<(U, T)>> @private(params nuint[] args)
			{
				return await Task.Run(() => @private(args.Append(args[^1] + 1).ToArray()));
			}

			internal unsafe string DoMiracle()
			{
				fixed (CHUDO<T, U>* p = &this) { }
				return "";
			}
		}

#nullable disable

		static void Main(string[] args)
		{ 
			var сulture = CultureInfo.GetCultureInfo("en-gb");
			var info = сulture.TextInfo;
			var name = "wrong_api";
			Console.WriteLine(info.ToTitleCase(name));

			Console.WriteLine("Hello World!");
		}
	}
}