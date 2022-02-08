using System;
using System.Collections.Generic;

namespace OfficeEmployee
{
    class OfficeEmployee
    {
        public string name;
        public GenderType gender;
        public int age;
        public string position;
        public int workExperience;
        public List<Award> awards;
        //Award singleAward;
        //Award singleAward2;
        //Award singleAward3;
        //Award[] awards1;

        public OfficeEmployee(string userName)
        {
            name = userName ?? throw new Exception("Имя не может быть пустым");
            age = 0;
            gender = default;
            position = "Не определено";
            awards = new List<Award>();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Сотрудник: {name}");
            Console.WriteLine($"Пол: {GetReadableGender(gender)}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Стаж работы(лет): {workExperience}");
            if (awards.Count > 0)
            {
                Console.WriteLine($"Полученные награды: ");
                foreach (var item in awards)
                {
                    Console.WriteLine($"    {GetReadableAward(item.type)}: {item.title}");
                }
            }
        }
        public static string GetReadableGender(GenderType gender)
        {
            switch (gender)
            {
                case GenderType.Male:
                    return "Мужской";
                case GenderType.Female:
                    return "Женский";
                default:
                    return "Не определен";
            }
        }
        public string GetReadableAward(AwardType award)
        {
            switch (award)
            {
                case AwardType.Diploma:
                    return "Диплом";
                case AwardType.Letter:
                    return "Благодарственное письмо";
                case AwardType.Medal:
                    return "Медаль";
                default:
                    return "Нет наград";
            }
        }
    }
    class Award
    {
        public AwardType type;
        public string title;
    }

    enum AwardType
    {
        Medal,
        Letter,
        Diploma
    }

    enum GenderType
    {
        Male,
        Female
    }
    class Program
    {
        static void Main()
        {

            var dmitry = new OfficeEmployee("Дмитрий")
            {
                gender = GenderType.Male,
                age = 34,
                position = "Руководитель проектного отдела",
                workExperience = 5
            };
            dmitry.awards.Add(new Award()
            {
                type = AwardType.Diploma,
                title = "Грамота"
            }
            );
            dmitry.awards.Add(new Award()
            {
                type = AwardType.Medal,
                title = "за 1 место в соревнованиях"
            }
            );
            dmitry.GetInfo();

            var alexey = new OfficeEmployee("Алексей")
            {
                gender = GenderType.Male,
                age = 55,
                position = "Инженер",
                workExperience = 10
            };
            alexey.awards.Add(new Award()
            {
                type = AwardType.Diploma,
                title = "Диплом лучшего сотрудника"
            }
            );
            alexey.GetInfo();

            var anastasia = new OfficeEmployee("Анастасия")
            {
                gender = GenderType.Female,
                age = 23,
                position = "Секретарь",
                workExperience = 1
            };
            anastasia.GetInfo();

            Console.Write("Введите имя сотрудника и нажмите клавишу Enter: ");
            var manualCreatedUser = new OfficeEmployee(Console.ReadLine());
            Console.Write("Введите возраст сотрудника и нажмите клавишу Enter: ");
            manualCreatedUser.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите должность сотрудника и нажмите клавишу Enter: ");
            manualCreatedUser.position = Console.ReadLine();
            Console.Write("Введите стаж работы сотрудника и нажмите клавишу Enter: ");
            manualCreatedUser.workExperience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите пол сотрудника: введите 1 - если мужской, 2 - женский и нажмите клавишу Enter: ");
            var userAnswerGender = Console.ReadLine();

            switch (userAnswerGender)
            {
                case "1":
                    manualCreatedUser.gender = GenderType.Male;
                    break;
                case "2":
                    manualCreatedUser.gender = GenderType.Female;
                    break;
                default:
                    throw new Exception("Некорректный пол");
            };

            var isAwardContinue = true;

            while(true)
            {
                Console.WriteLine("Выберите, какую награду получил сотрудник:");
                Console.Write("введите 1 - диплом, 2 - медаль, 3 - благодарственное письмо, 0 - закончить ввод наград, и нажмите клавишу Enter: ");
                var userAnswerAward = Console.ReadLine();
                AwardType? award = null;
                switch (userAnswerAward)
                {
                    case "1":
                        award = AwardType.Diploma;
                        break;
                    case "2":
                        award = AwardType.Medal;
                        break;
                    case "3":
                        award = AwardType.Letter;
                        break;
                    default:
                        isAwardContinue = false;
                        break;
                };

                if (!isAwardContinue)
                {
                    break;
                }

                Console.Write("Введите описание награды и нажмите клавишу Enter: ");
                string userAnswerAwardTitle = Console.ReadLine();
                manualCreatedUser.awards.Add(new Award()
                {
                    type = award.Value,
                    title = userAnswerAwardTitle
                });
            };

            manualCreatedUser.GetInfo();
        }
    }

}
