using System;
public class Pupil
{
    public virtual void Study() { Console.WriteLine("Учится");}
    public virtual void Read() { Console.WriteLine("Читает");}
    public virtual void Write() { Console.WriteLine("Пишет.");}
    public virtual void Relax() { Console.WriteLine("Отдыхает.");}
}

public class ExcelentPupil : Pupil
{
    public override void Study() {Console.WriteLine("Учится отлично");}
    public override void Read() { Console.WriteLine("Читает много");
    public override void Write() { Console.WriteLine("Пишет отлично"); }
    public override void Relax() { Console.WriteLine("Отдыхает мало"); }
}

public class GoodPupil : Pupil
{
    public override void Study() {  Console.WriteLine("Учится нормально"); }
    public override void Read() { Console.WriteLine("Читает немало");
    public override void Write() { Console.WriteLine("Пишет нормально");}
    public override void Relax() { Console.WriteLine("Отдыхает немного");}
}

public class BadPupil : Pupil
{
    public override void Study() {Console.WriteLine("Учится плохо");}
    public override void Read() { Console.WriteLine("Читает мало");}
    public override void Write() { Console.WriteLine("Пишет плохо");}
    public override void Relax() { Console.WriteLine("Отдыхает много");}
}
public class ClassRoom
{
    private Pupil[] pupils;
    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length < 2 || pupils.Length > 4)
            throw new ArgumentException("Не то кол-во");
        this.pupils = pupils;
    }
    public void ShowPupilsSkills()
    {
        foreach (var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcelentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new ExcelentPupil();
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.ShowPupilsSkills();
    }
}
