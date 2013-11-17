/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Animal[] zoo =
        {
            new Dog("sharo1", "male",10),
            new Dog("sharo2", "male",15),
            new Frog("jabcho1", "male",1),
            new Frog("jabcho2", "male",3),
            new Frog("jabcho3", "male",2),
            new Kitten("kitty1", 5),
            new Kitten("kitty2", 6),
            new Kitten("kitty3", 1),
            new Kitten("kitty4", 51),
            new Tomcat("tomcat",3)
        };

        Animal.PrintAverage(zoo);
    }
}

