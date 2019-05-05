using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Globalization;
using System.Reactive.Linq;

namespace StringFormatDesigner
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            this.WhenAnyValue(x => x.Format)
                .Throttle(TimeSpan.FromMilliseconds(400))
                .DistinctUntilChanged()
                .Subscribe(_ => this.DoOutput());

            this.WhenAnyValue(x => x.Culture)
                .Throttle(TimeSpan.FromMilliseconds(400))
                .DistinctUntilChanged()
                .Subscribe(x =>
                {
                    CultureInfo.CreateSpecificCulture(x);

                });

            this.WhenAnyValue(x => x.Input)
                .Throttle(TimeSpan.FromMilliseconds(400))
                .DistinctUntilChanged()
                .Subscribe(_ => this.DoOutput());
        }


        [Reactive] public string Input { get; set; }
        [Reactive] public string Format { get; set; }
        [Reactive] public string Culture { get; set; }
        [Reactive] public string Output { get; private set; }


        void DoOutput()
        {
            // TODO: get parser, use tostring
            String.Format(this.Input, this.Format);
        }
    }
}
