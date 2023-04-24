using System;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public interface ISupportRequestHandler
    {
        public void Handle(SupportContext context);
    }
}
