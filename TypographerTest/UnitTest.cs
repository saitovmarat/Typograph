using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using Typograph;

namespace TypographTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FirstRuleTest()
        {
            string testResult = Rules.FirstRule("\" � , ������� , ������� ����� �� ������� \"");
            string rightResult = "\"�,  �������,  �������  ����� �� �������\"";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void SecondRuleTest()
        {
            string testResult = Rules.SecondRule("��  ����  ����  ");
            string rightResult = "�� ���� ���� ";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void SixthRuleTest()
        {
            string testResult = Rules.SixthRule("����� - ����� �������� ����");
            string rightResult = "����� � ����� �������� ����";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void ThirteenthRuleTest()
        {
            string testResult = Rules.ThirteenthRule("����... �������... � ��� ���� ����� ������...");
            string rightResult = "����� �������� � ��� ���� ����� �������";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void FirstOwnRuleTest()
        {
            string testResult = Rules.FirstOwnRule("� ����� ������ �������");
            string rightResult = "� ����� ������ �������.";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void SecondOwnRuleTest()
        {
            string testResult = Rules.SecondOwnRule("���� ���� ����� ��� ������� � �����");
            string rightResult = "*������ �����* *������ �����* ����� ��� ������� � �����";
            Assert.AreEqual(rightResult, testResult);
        }



        [TestMethod]
        public void DontKnowTest1()
        {

        }
        [TestMethod]
        public void DontKnowTest2()
        {

        }
        [TestMethod]
        public void DontKnowTest3()
        {

        }
        [TestMethod]
        public void DontKnowTest4()
        {

        }
        [TestMethod]
        public void DontKnowTest5()
        {

        }
        [TestMethod]
        public void DontKnowTest6()
        {

        }
        [TestMethod]
        public void DontKnowTest7()
        {

        }
        [TestMethod]
        public void DontKnowTest8()
        {

        }
        [TestMethod]
        public void DontKnowTest9()
        {

        }
    }
}
