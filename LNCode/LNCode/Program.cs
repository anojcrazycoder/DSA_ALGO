// See https://aka.ms/new-console-template for more information
using LNCode.Array;

Console.WriteLine("Hello, World!");

List<string> list = new List<string>();
list.Add("Anoj#");
list.Add("##Akshada");
list.Add("*Raju**");



string a = EncodeDecode.Encode(list);

List<String> list2 = EncodeDecode.Decode(a);
