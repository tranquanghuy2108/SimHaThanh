using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Sendbird.Chat;

namespace Services.Implement
{
    public class SendbirdService
    {
        private readonly string _appId;
        private readonly string _userId;
        private readonly string _apiToken;

        public SendbirdService(string appId, string userId, string apiToken)
        {
            _appId = appId;
            _userId = userId;
            _apiToken = apiToken;
            SendbirdChat.Init(new SbInitParams(_appId));
            SendbirdChat.Connect(
                _userId,
                _apiToken,
                (inUser, inError) =>
                {
                    if (inError != null)
                    {
                        return; // Handle error.
                    }
                }
            );
        }
    }
}
