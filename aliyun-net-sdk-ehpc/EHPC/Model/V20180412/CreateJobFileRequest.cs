/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class CreateJobFileRequest : RpcAcsRequest<CreateJobFileResponse>
    {
        public CreateJobFileRequest()
            : base("EHPC", "2018-04-12", "CreateJobFile", "ehs", "openAPI")
        {
        }

		private string targetFile;

		private string runasUserPassword;

		private string runasUser;

		private string clusterId;

		private string content;

		public string TargetFile
		{
			get
			{
				return targetFile;
			}
			set	
			{
				targetFile = value;
				DictionaryUtil.Add(QueryParameters, "TargetFile", value);
			}
		}

		public string RunasUserPassword
		{
			get
			{
				return runasUserPassword;
			}
			set	
			{
				runasUserPassword = value;
				DictionaryUtil.Add(QueryParameters, "RunasUserPassword", value);
			}
		}

		public string RunasUser
		{
			get
			{
				return runasUser;
			}
			set	
			{
				runasUser = value;
				DictionaryUtil.Add(QueryParameters, "RunasUser", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

        public override CreateJobFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateJobFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
