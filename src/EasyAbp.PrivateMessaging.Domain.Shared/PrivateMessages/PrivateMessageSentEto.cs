﻿using System;
using JetBrains.Annotations;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.PrivateMessaging.PrivateMessages
{
    [Serializable]
    public class PrivateMessageSentEto : IMultiTenant
    {
        public Guid? TenantId { get; set; }
        
        public Guid PrivateMessageId { get; set; }
        
        public Guid? FromUserId { get; set; }
        
        [CanBeNull]
        public string FromUserName { get; set; }
        
        public Guid ToUserId { get; set; }
        
        [NotNull]
        public string ToUserName { get; set; }
        
        public DateTime SentTime { get; set; }
        
        [NotNull]
        public string Title { get; set; }

        public PrivateMessageSentEto(Guid? tenantId, Guid privateMessageId, Guid? fromUserId,
            [CanBeNull] string fromUserName, Guid toUserId, [NotNull] string toUserName, DateTime sentTime,
            [NotNull] string title)
        {
            TenantId = tenantId;
            PrivateMessageId = privateMessageId;
            FromUserId = fromUserId;
            FromUserName = fromUserName;
            ToUserId = toUserId;
            ToUserName = toUserName;
            SentTime = sentTime;
            Title = title;
        }
    }
}