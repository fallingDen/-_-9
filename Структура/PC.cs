using System;
using System.Xml.Linq;

namespace Структура
{
    
        
       public struct PC
        {
            public string TypeProcessor;
            public int Memory;
            public int HDD;
            public string Video; // Поля

            public int N { get; set; } // поле 
            
            
            public PC(string typeProcessor, int memory, int hdd, string video)
            {
                TypeProcessor = typeProcessor;
                Memory = memory;
                HDD = hdd;
                Video = video;
                N = 0;
            } // Конструктор

            public override string ToString()
            {
                return $"{N}- тип процессора- {TypeProcessor}, RAM- {Memory} гб, HDD- {HDD} гб, видео- {Video}";
            } // запись в лист

        } 
        
    
}
