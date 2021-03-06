// Copyright (c) 2015 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.IO;
using Alachisoft.NCache.Web.Caching.Util;

namespace Alachisoft.NCache.Web.Command
{
    internal sealed class InitSecondarySocketCommand : CommandBase
    {
        private string _clientID;

        public InitSecondarySocketCommand(string clientid)
        {
            base.name = "InitSecondarySocketCommand";
            this._clientID = clientid;
        }

        internal override CommandType CommandType
        {
            get { return CommandType.INIT_SECONDARY; }
        }

        internal override RequestType CommandRequestType
        {
            get { return RequestType.InternalCommand; }
        }

        protected override void CreateCommand()
        {
            base.ConstructCommand("InitSecondarySocketCommand \"" + base.RequestId + "\"" + this._clientID + "\"Y\"", new byte[0]);
        }
    }
}
