using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace CloudApp
{
    public partial class frm_form_yukle : Form
    {
        public string link;
        public string kod;
        public frm_form_yukle()
        {
            InitializeComponent();
        }
        WebClient wb = new WebClient();
        List<string> AllAssemblyFiles;

        private void frm_form_yukle_Load(object sender, EventArgs e)
        {
            wb.Encoding = Encoding.UTF8;
            wb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wb_DownloadProgressChanged);
            wb.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wb_DownloadStringCompleted);
            wb.DownloadStringAsync(new Uri("http://mustafauzun0.16mb.com/FORM/" + link));
        }
        void Calistir(string kod) //Kod derleme
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();

            ICodeCompiler compiler = codeProvider.CreateCompiler();
            CompilerParameters parameters = new CompilerParameters();
            parameters.CompilerOptions = "/target:winexe"; //Kodu Form formatında çalıştır
            parameters.GenerateExecutable = true;
            //Hafızada yer tutmaması için
            parameters.GenerateInMemory = false;
            //parameters.OutputAssembly = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "\\Kod.exe"); //kodu kaydetme
            /*Kodu kaydetmezsiniz çalıştırılan dosyalar temp dosyasında oluşturulur ve benzersiz bir isim alır*/
            parameters.IncludeDebugInformation = false;

            //Mevcut assemblyleri ekle
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                parameters.ReferencedAssemblies.Add(asm.Location);
            }

            String code = kod;
            CompilerResults results = compiler.CompileAssemblyFromSource(parameters, code);
            try
            {
                System.Diagnostics.Process.Start(parameters.OutputAssembly); //Kod yolunu çalıştır
            }
            catch
            {
                string errorText = String.Empty;
                foreach (CompilerError compilerError in results.Errors) //Hataları listeler
                    errorText += compilerError + "\n";
                MessageBox.Show(errorText, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        void wb_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            kod = e.Result; //Yüklenen stringi kod adlı değişkene atar
            Calistir(kod);
            this.Close();
        }

        void wb_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbr_yukle.Value = e.ProgressPercentage; //Dosya indirilken progressbarda göster
        }

    }
}
