using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace SerialDeserial
{
    class Serialization
    {
        public int Serialize(int num)
        {
            int jsonstring = JsonSerializer.Serialize(num);
            return jsonstring;
        }

        //public Product DeSerialize()
        //{

        //}
    }
}
