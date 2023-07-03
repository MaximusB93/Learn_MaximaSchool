using System;

namespace GetMails
{
    public class Human
    {
        public event EventHandler<MailEventArgs> GetMailEvent;


        public void AddMail(Mail mail)
        {
            OnGetMailEvent(new MailEventArgs(mail));
        }
        protected virtual void OnGetMailEvent(MailEventArgs e)
        {
            var list = GetMailEvent.GetInvocationList();
            GetMailEvent?.Invoke(this, e);
        }
    }

    public class MailEventArgs : EventArgs
    {
        public Mail Mail { get; set; }
        public MailEventArgs(Mail mail)
        {
            Mail = mail;
        }
    }

    public class Mail
    {
        public string Tekst { get; set; }
        public string Address { get; set; }
        public string Author { get; set; }

        public Mail(string tekst, string address, string author)
        {
            Tekst = tekst;
            Address = address;
            Author = author;
        }

        public override string ToString()
        {
            return $"{nameof(Tekst)}: {Tekst}, {nameof(Address)}: {Address}, {nameof(Author)}: {Author}";
        }
    }
}

