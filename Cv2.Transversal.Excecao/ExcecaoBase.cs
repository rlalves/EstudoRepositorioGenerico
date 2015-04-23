using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Transversal.Excecao.Interfaces;
using Cv2.Transversal.Log;
using System.Diagnostics;

namespace Cv2.Transversal.Excecao
{
    public class ExcecaoBase : IExcecaoBase
    {
        protected Logger log;

        protected int idArquivo;

        protected string erro = string.Empty;
        protected string arquivo = string.Empty;
        protected string metodo = string.Empty;
        protected string linha = string.Empty;

        public ExcecaoBase(Exception e)
        {
            log = new Logger();
            StackTrace trace = new StackTrace(e, true);

            int idArquivo = trace.GetFrame(trace.FrameCount - 1).GetFileName().LastIndexOf("\\") + 1;

            erro = e.Message;
            arquivo = trace.GetFrame(trace.FrameCount - 1).GetFileName().Substring(idArquivo).ToString();
            metodo = trace.GetFrame(trace.FrameCount - 1).GetMethod().Name;
            linha = trace.GetFrame(trace.FrameCount - 1).GetFileLineNumber().ToString();

            TratarErro();
        }

        protected string TratarErro()
        {
            log.GravaLog(MontarMensagemLog());
            return MontarMensagemTela();
        }

        protected string MontarMensagemLog()
        {
            return "Erro  : " + erro + " Origem: " + arquivo + " Metodo: " + metodo + " Linha : " + linha;
        }

        protected string MontarMensagemTela()
        {
            return "<b>Erro  :</b> " + erro + "</br> <b>Origem:</b> " + arquivo + "</br> <b>Metodo:</b> " + metodo + "</br> <b>Linha :</b> " + linha + "</br>";
        }
    }
}
