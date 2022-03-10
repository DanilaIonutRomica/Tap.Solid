﻿namespace Tap.Solid.Lsp
{
    internal abstract class MobilePhone
    {
        internal abstract void MakePhoneCall(string phoneNumber);
        internal abstract void SendSms(string phoneNumber);
       // internal abstract void SendEmail(string emailAdress);
       // internal abstract void BrowseWeb(string webAdress);
    }
    internal abstract class SmartPhone :MobilePhone
    {
        internal abstract void SendEmail(string emailAdress);
        internal abstract void BrowseWeb(string webAdress);
    }
}
