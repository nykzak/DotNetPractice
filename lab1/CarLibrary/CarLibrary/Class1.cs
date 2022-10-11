using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CarLibrary
{
    // Представляет состояние двигателя,
    public enum EngineState
    { engineAlive, engineDead }
    // Абстрактный базовый класс в иерархии,
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        protected EngineState egnState = EngineState.engineAlive;
        public EngineState EngineState
        {
            get { return egnState; }
        }
        public abstract void TurboBoost();
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            PetName = name; MaxSpeed = maxSp; CurrentSpeed = currSp;
        }
    }


    public class SportsCar : Car
    {
        public SportsCar() { }
        public SportsCar(string name, int maxSp, int currSp)
        : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            MessageBox.Show("Faster is b e t t e r . . . ", "Ramming speed!");
        }
    }
    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSp, int currSp)
        : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            // Минивэны имеют плохие возможности ускорения!
            egnState = EngineState.engineDead;
            MessageBox.Show("Your engine block exploded!", "Eek!");
            MessageBox.Show("Say goodbye for your engine", "BYE");

        }
    }
}
