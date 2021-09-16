using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections.Generic;

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

			public delegate Task<IEnumerable<TReturn>> VsDel<TArg, TReturn>(TArg p0 = default, params TArg[] ps)
				where TArg : struct;

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

			static string Classify(double measurement) => measurement switch
			{
				< -40.0 => "Too low",
				>= -40.0 and < 0 => "Low",
				>= 0 and < 10.0 => "Acceptable",
				>= 10.0 and < 20.0 => "High",
				>= 20.0 => "Too high",
				double.NaN => "Unknown",
			};

			static bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');


			static async IAsyncEnumerable<string> TakeFive(object input)
			{
				yield return (await MakeWorkAsync(input) switch
				{
					string { Length: >= 5 } s => s.Substring(0, 5),
					string s => s,

					ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
					ICollection<char> symbols => new string(symbols.ToArray()),

					null => throw new ArgumentNullException(nameof(input)),
					_ => throw new ArgumentException("Not supported input type."),
				}).Trim();
			}

			static Task<object> MakeWorkAsync(object o)
			{
				return Task.FromResult(o);
			}

			static string TakeFive_old(object input)
			{
				if(input is string s)
				{
					if (s.Length >= 5)
						return s.Substring(0, 5);
					
					return s;
				}

				if(input is ICollection<char> c)
				{
					if (c.Count >= 5)
						return new string(c.Take(5).ToArray());
					
					return new string(c.ToArray());
				}

				if (input is null)
					throw new ArgumentNullException(nameof(input));

				throw new ArgumentException("Not supported input type.");
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

		public virtual async Task<IEnumerable<int>> Vs(string p1 = "adf", params string[] ps)
		{
			//var t = new VsDel(Vs);

			//t.Method.
			
			return await Task.FromResult(new int[0]);
		}
	}
}