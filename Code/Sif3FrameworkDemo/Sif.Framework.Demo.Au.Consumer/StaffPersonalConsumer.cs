﻿/*
 * Copyright 2015 Systemic Pty Ltd
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Sif.Framework.Consumer;
using Sif.Framework.Demo.Au.Consumer.Models;
using Sif.Framework.Model.Infrastructure;

namespace Sif.Framework.Demo.Au.Consumer
{

    /// <summary>
    /// 
    /// </summary>
    class StaffPersonalConsumer : GenericConsumer<StaffPersonal, string>, IStaffPersonalConsumer
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationKey"></param>
        /// <param name="instanceId"></param>
        /// <param name="userToken"></param>
        /// <param name="solutionId"></param>
        public StaffPersonalConsumer(string applicationKey, string instanceId = null, string userToken = null, string solutionId = null)
            : base(applicationKey, instanceId, userToken, solutionId)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment"></param>
        public StaffPersonalConsumer(Environment environment)
            : base(environment)
        {

        }

    }

}