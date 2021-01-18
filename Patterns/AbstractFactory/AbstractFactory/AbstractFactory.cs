using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        //Абстрактная Фабрика-это порождающий паттерн проектирования.
        //Он позволяет создавать семейства связанных объектов, не привязываясь к конкретным классам создаваемых объектов.
        //Этот паттерн можно использовать когда в проекте надо создать множесто обьектов схожих между собой 
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
