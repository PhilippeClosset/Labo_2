using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.BLL.BusinessException
{
    public class FilmException : Exception
    {
        public FilmException() { }
        public FilmException(string? message) : base(message) { }
    }
    public class FilmNotFoundException : FilmException
    {
        public FilmNotFoundException() : base("Film introuvable") { }
    }
}
