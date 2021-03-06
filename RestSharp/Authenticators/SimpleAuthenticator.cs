﻿#region License
//   Copyright 2009 John Sheehan
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

namespace RestSharp
{
	public class SimpleAuthenticator : IAuthenticator
	{
		public string _usernameKey { get; set; }
		public string _username { get; set; }
		public string _passwordKey { get; set; }
		public string _password { get; set; }

		public SimpleAuthenticator(string UsernameKey, string Username, string PasswordKey, string Password) {
			_password = Password;
			_passwordKey = PasswordKey;
			_username = Username;
			_usernameKey = UsernameKey;
		}

		public void Authenticate(RestRequest request) {
			request.AddParameter(_usernameKey, _username);
			request.AddParameter(_passwordKey, _password);
		}
	}
}
