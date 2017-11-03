﻿using System;
using System.Collections.Generic;

namespace LeagueGram.Domain
{
  public class Channel : PublicChat
  {
    public Channel(Guid id, Guid creatorId, IEnumerable<Message> messages, IEnumerable<ChatMember> members) 
      : base(id, creatorId, messages, members)
    {
    }

    protected override bool CanSendMessage(ChatMember chatMember)
    {
      return chatMember.Role == ChatMemberRole.Admin;
    }

    protected override bool CanEditMessage(ChatMember chatMember, Message message)
    {
      return chatMember.Role == ChatMemberRole.Admin;
    }

    protected override bool CanDeleteMessage(ChatMember chatMember, Message message)
    {
      return chatMember.Role == ChatMemberRole.Admin;
    }

    protected override bool CanInvite(ChatMember chatMember)
    {
      return chatMember.Role == ChatMemberRole.Admin;
    }

    protected override bool CanPromote(ChatMember chatMember)
    {
      return chatMember.Id == CreatorId;
    }

    protected override bool CanDemote(ChatMember chatMember)
    {
      return chatMember.Id == CreatorId;
    }
  }
}
