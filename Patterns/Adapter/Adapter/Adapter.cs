using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : GlamorousPussyClass,Interface1
    {
        //Для того что бы не менять исходный кисо-класс мы наследуюемся от него и уже новый класс реализует интерфейс.Таким образом мы оставили тот же функционал и реализовали интерфейс.При этом нам не пришлось менять исходный класс.
    }
}
