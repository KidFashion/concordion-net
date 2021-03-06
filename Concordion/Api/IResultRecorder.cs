﻿// Copyright 2009 Jeffrey Cameron
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concordion.Api
{
    /// <summary>
    /// Records the results of running a specification and indicates whether or not the specification passed or failed
    /// </summary>
    public interface IResultRecorder
    {
        /// <summary>
        /// Records the specified result.
        /// </summary>
        /// <param name="result">The result.</param>
        void Record(Result result);

        /// <summary>
        /// Indicate a successfull assert.
        /// </summary>
        void Success();

        /// <summary>
        /// Indicate a failing assert.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="stackTrace">Stack trace giving the location of the failure</param>
        void Failure(string message, string stackTrace);

        /// <summary>
        /// Indicate an unhandled exception during test execution.
        /// </summary>
        /// <param name="exception">The occured exception.</param>
        void Error(Exception exception);

        void Ignore();

        void AddResultDetails(List<ResultDetails> resultDetails);
    }
}
