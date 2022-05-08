using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_Profive_Change_name_and_surname : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Изменение имени и фамилии в ЛК", homePage => ChangeNameAndSurname(homePage)));
            return caseCollection;
        }



        void ChangeNameAndSurname(PortalHomePage homePage)
        {
            //Клик на имя пользователя
            //Перейти в настройки профиля 
            //Изменить имя 
            //Изменить фамилию 
            //Нажать на сохранить 

            homePage.MainPage.ClickUserName();

        }
    }
}
