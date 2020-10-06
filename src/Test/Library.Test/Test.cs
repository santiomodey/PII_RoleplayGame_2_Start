using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
   
    public class Test
    {
         private Dwarf dwarf;
         private Dwarf dwarf1;

        [SetUp]
        public void SetUp()
        {
            dwarf = new Dwarf("Dwarf");
            dwarf1 = new Dwarf("Dwarf");
            Axe axe = new Axe();
            dwarf.Axe = axe;
            Shield shield = new Shield();
            Helmet helmet = new Helmet();
            dwarf.Shield = shield;
            dwarf.Helmet= helmet;
            dwarf1.Axe = axe;
            dwarf1.Shield = shield;
            dwarf1.Helmet= helmet;
        }
        //Ataque a dwarf y comprueba que la vida sea correcta
        [Test]
        public void Test1()
        {
             dwarf.ReceiveAttack(dwarf1.AttackValue);
             Assert.AreEqual(dwarf.Health,100);
        }
        
        // //Comprueba el nombre si es correcto
        [Test]
        public void Test2()
        {
             Assert.AreEqual(dwarf.Name,"Dwarf");

        }
        // //Comprueba que la vida no baja de 0, debido a que no existe vida negativa ya que con 0 ya estarĂ­a muerto.
        [Test]
        public void Test3()
        {
             dwarf.ReceiveAttack(1000);
             dwarf.ReceiveAttack(1000);
             dwarf.ReceiveAttack(1000);
             Assert.AreEqual(dwarf.Health,0);

        }
        //Lo atacan y le recupera la vida
         [Test]
        public void Test4()
        {
            dwarf.ReceiveAttack(dwarf.AttackValue);
            dwarf.Cure();
            Assert.AreEqual(dwarf.Health, 100);

        }
        
        
    }


}