using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BobProblem.UnitTest
{
    public class BobUnitTest
    {
        private Bob bob;
        public BobUnitTest()
        {
            bob = new Bob();
        }

        [Fact]
        public void Bob_ShouldReturnWhatEver_WhenAnythingElse()
        {
            Assert.Equal("Whatever.", bob.hey("dfsaffddsfsafdsfasd"));

        }


        [Fact]
        public void Bob_ShouldReturnChillOut_WhenYellingAtHim()
        {
            Assert.Equal("Whoa, chill out!", bob.hey("HEY HEY HEY"));
        }


        [Fact]
        public void Bob_ShouldReturnSure_WhenAskAQuestion()
        {
            Assert.Equal("Sure.", bob.hey("what are you doing?"));
        }


        [Fact]
        public void Bob_ShouldReturnCalmDown_WhenYellAQuestion()
        {
            Assert.Equal("Calm down, I know what I'm doing!", bob.hey("WHAT ARE YOU DOING?"));
        }


        [Fact]
        public void Bob_ShouldReturnFine_WhenAddressHimWithoutActuallySayingAnything()
        {
            Assert.Equal("Fine. Be that way!", bob.hey(""));
        }


        [Fact]
        public void Bob_ShouldReturnChillOut_WhenQuestionMarkInMiddle()
        {
            Assert.Equal("Whoa, chill out!", bob.hey("what do you mean? hey hey hey"));
        }


        [Fact]
        public void Bob_ShouldReturnFine_WhenMessageHasSpaceOrTab()
        {
            Assert.Equal("Fine. Be that way!", bob.hey("\t \b \t \t"));
        }



        [Fact]
        public void Bob_ShouldReturnChillOut_WhenAskQuestionWithSpecialCharacter()
        {
            Assert.Equal("Calm down, I know what I'm doing!", bob.hey("What are you #$#$#%# thinking?"));
        }

    }
}
