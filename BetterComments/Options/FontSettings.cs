using System.ComponentModel;
using System.Runtime.CompilerServices;
using BetterComments.Annotations;

namespace BetterComments.Options
{
    public class FontSettings : INotifyPropertyChanged
    {
        private string font = string.Empty;
        private bool italic;
        private double size;
        private double opacity;
        private bool highlightKeywordsesOnly;
        private bool underlineImportantComments;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Font
        {
            get { return font; }
            set
            {
                if (value == font)
                    return;
                font = value;
                OnPropertyChanged();
            }
        }

        public double Size
        {
            get { return size; }
            set
            {
                if (value.Equals(size))
                    return;

                size = value;
                OnPropertyChanged();
            }
        }

        public bool Italic
        {
            get { return italic; }
            set
            {
                if (value == italic)
                    return;
                italic = value;
                OnPropertyChanged();
            }
        }
        
        public double Opacity
        {
            get { return opacity; }
            set
            {
                if (value.Equals(opacity)) return;
                opacity = value;
                OnPropertyChanged();
            }
        }

        public bool HighlightKeywordsOnly
        {
            get { return highlightKeywordsesOnly; }
            set
            {
                if (value == highlightKeywordsesOnly) return;
                highlightKeywordsesOnly = value;
                OnPropertyChanged();
            }
        }

        public bool UnderlineImportantComments
        {
            get { return underlineImportantComments; }
            set
            {
                if (value == underlineImportantComments) return;
                underlineImportantComments = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
