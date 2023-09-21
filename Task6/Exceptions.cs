using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class RemoveAutoException : Exception
    {
        public RemoveAutoException()
            : base("Невозможно удалить авто.")
        { }
    }

    public class InitializationException : Exception 
    {
        public InitializationException()
            : base("Невозможно инициализировать авто.")
        { }

    }

    public class UpdateCarException : Exception
    {
        public UpdateCarException()
            : base("Невозможно обновить авто.")
        { }

    }

    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException()
            : base("Невозможно найти по параметру авто.")
        { }
    }

    public class AddAutoException : Exception
    {
        public AddAutoException()
                : base("Невозможно добавить авто.")
        { }

    }
}


