using System;
using System.IO;
using System.Text;

namespace CreateFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string broot = @"C:\Users\bizca\OneDrive - Bizcad Systems\";
            string proot = @"C:\Users\bizca\OneDrive\";
            DirectoryInfo binfo = new DirectoryInfo(broot);
            DirectoryInfo pinfo = new DirectoryInfo(proot);
            CreateFolders(pinfo, binfo);
        }
        static void CreateFolders(DirectoryInfo source, DirectoryInfo dest)
        {
            foreach (var s in source.EnumerateDirectories())
            {
                
                StringBuilder sb = new StringBuilder();
                sb.Append(dest.FullName);
                sb.Append(s.Name);
                sb.Append(@"\");
                string newdestfullpath = sb.ToString();
                DirectoryInfo newdestinfo = new DirectoryInfo(newdestfullpath);
                sb = new StringBuilder();
                sb.Append(source.FullName);
                sb.Append(s.Name);
                sb.Append(@"\");
                string newsourcefullpath = sb.ToString();
                DirectoryInfo newsourceinfo = new DirectoryInfo(newsourcefullpath);
                

                if (!newdestinfo.Exists)
                {
                    newdestinfo.Create();
                    Console.WriteLine($"Created {newdestinfo.FullName}"); 
                }
                CreateFolders(newsourceinfo, newdestinfo);
            }

        }
    }
}
