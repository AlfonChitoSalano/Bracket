using BracketPoc;
using Shouldly;

namespace Tests.StepDefinitions;

[Binding]
public class BracketValidCheckerStepDefinitions
{
    private string _input = string.Empty;
    private bool _expectedResult;

    [Given(@"I have a string ""(.*)""")]
    public void GivenIHaveAString(string input)
    {
        _input = input;
    }

    [When(@"I check if the brackets are correct or not")]
    public void WhenICheckIfTheBracketsAreCorrectOrNot()
    {
        _expectedResult = Bracket.Check(_input);
    }

    [Then(@"the result should be valid")]
    public void ThenTheResultShouldBeValid()
    {
        _expectedResult.ShouldBeTrue();
    }

    [Then(@"the result should be not valid")]
    public void ThenTheResultShouldBeNotValid()
    {
        _expectedResult.ShouldBeFalse();
    }
}