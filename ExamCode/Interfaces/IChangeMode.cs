
namespace ExamCode.Interfaces
{
    internal interface IWeapon
    {
        public bool IsAuto { get; set; }

        public void ChangeFireMode();
    }
}
