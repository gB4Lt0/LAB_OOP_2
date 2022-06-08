﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Library
{
    public class Serializator<T>
    {
        private readonly string _path;

        public Serializator(string path)
        {
            _path = path;
        }

        public void Serialize(T model)
        {
            var jsonContent = JsonConvert.SerializeObject(model);

            File.WriteAllText(_path, jsonContent);
        }

        public T Deserialize()
        {
            var jsonContent = File.ReadAllText(_path);

            return JsonConvert.DeserializeObject<T>(jsonContent);
        }
    }
}
