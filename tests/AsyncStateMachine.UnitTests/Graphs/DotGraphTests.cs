﻿using AsyncStateMachine.Graphs;
using System;
using Xunit;

namespace AsyncStateMachine.UnitTests.Graphs
{
    public class DotGraphTests
    {
        private enum Trigger
        {
            a
        }

        private enum State
        {
            A
        }

        [Fact]
        public void Plot_NullTransitions_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => DotGraph.Format<Trigger, State>(null));
        }
    }
}