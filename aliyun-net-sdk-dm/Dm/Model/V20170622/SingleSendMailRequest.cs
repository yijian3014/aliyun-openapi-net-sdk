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
using Aliyun.Acs.Dm.Transform;
using Aliyun.Acs.Dm.Transform.V20170622;

namespace Aliyun.Acs.Dm.Model.V20170622
{
    public class SingleSendMailRequest : RpcAcsRequest<SingleSendMailResponse>
    {
        public SingleSendMailRequest()
            : base("Dm", "2017-06-22", "SingleSendMail", "dm", "openAPI")
        {
        }

		private string htmlBody;

		private string fromAlias;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string toAddress;

		private string clickTrace;

		private string subject;

		private long? ownerId;

		private string replyAddressAlias;

		private string accessKeyId;

		private string tagName;

		private string accountName;

		private bool? replyToAddress;

		private string replyAddress;

		private string action;

		private int? addressType;

		private string textBody;

		public string HtmlBody
		{
			get
			{
				return htmlBody;
			}
			set	
			{
				htmlBody = value;
				DictionaryUtil.Add(QueryParameters, "HtmlBody", value);
			}
		}

		public string FromAlias
		{
			get
			{
				return fromAlias;
			}
			set	
			{
				fromAlias = value;
				DictionaryUtil.Add(QueryParameters, "FromAlias", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string ToAddress
		{
			get
			{
				return toAddress;
			}
			set	
			{
				toAddress = value;
				DictionaryUtil.Add(QueryParameters, "ToAddress", value);
			}
		}

		public string ClickTrace
		{
			get
			{
				return clickTrace;
			}
			set	
			{
				clickTrace = value;
				DictionaryUtil.Add(QueryParameters, "ClickTrace", value);
			}
		}

		public string Subject
		{
			get
			{
				return subject;
			}
			set	
			{
				subject = value;
				DictionaryUtil.Add(QueryParameters, "Subject", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ReplyAddressAlias
		{
			get
			{
				return replyAddressAlias;
			}
			set	
			{
				replyAddressAlias = value;
				DictionaryUtil.Add(QueryParameters, "ReplyAddressAlias", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string TagName
		{
			get
			{
				return tagName;
			}
			set	
			{
				tagName = value;
				DictionaryUtil.Add(QueryParameters, "TagName", value);
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public bool? ReplyToAddress
		{
			get
			{
				return replyToAddress;
			}
			set	
			{
				replyToAddress = value;
				DictionaryUtil.Add(QueryParameters, "ReplyToAddress", value.ToString());
			}
		}

		public string ReplyAddress
		{
			get
			{
				return replyAddress;
			}
			set	
			{
				replyAddress = value;
				DictionaryUtil.Add(QueryParameters, "ReplyAddress", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public int? AddressType
		{
			get
			{
				return addressType;
			}
			set	
			{
				addressType = value;
				DictionaryUtil.Add(QueryParameters, "AddressType", value.ToString());
			}
		}

		public string TextBody
		{
			get
			{
				return textBody;
			}
			set	
			{
				textBody = value;
				DictionaryUtil.Add(QueryParameters, "TextBody", value);
			}
		}

        public override SingleSendMailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SingleSendMailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
