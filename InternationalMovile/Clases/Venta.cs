using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalMovile.Clases
{
    class Venta
    {

        public static void Imprimir(string FilePath)
        {

            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Document document = application.Documents.Open(FilePath);
            
            try
            {
                document.PrintOut();
            }
            catch (Exception es)
            {
                throw es;
            }
            finally
            {
                application.Quit();
            }


        }

    }
}
