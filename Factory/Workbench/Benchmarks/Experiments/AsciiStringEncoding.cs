using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Jobs;
using static System.Text.Encoding;

namespace Benchmarks.Experiments
{
    [SimpleJob(10), MemoryDiagnoser]
    [RankColumn]
    public class AsciiStringEncoding
    {
        private static class Constants
        {
            public const string StringLength12 = "Hello world!";
            public const string StringLength900 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas blandit enim quis lorem hendrerit, in elementum nisl commodo. Mauris sapien dui, convallis et nunc id, ullamcorper porta lectus. Maecenas eu risus elit. Etiam quis nulla est. Sed fringilla feugiat ipsum, vel consectetur leo congue ac. Vestibulum eget nisl sed arcu finibus facilisis. Sed ultricies at enim non auctor. Cras arcu lacus, semper et pulvinar eu, dapibus a massa. Donec tempor, nibh et maximus aliquet, risus lorem consectetur est, et consectetur sem justo non quam. Vivamus eu tristique magna, commodo egestas purus. In hac habitasse platea dictumst. Ut eros urna, luctus sit amet ornare ut, bibendum sit amet eros. Nullam finibus turpis ac urna scelerisque rhoncus. Aliquam imperdiet sollicitudin nunc quis commodo. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi turpis duis.";
            public const string StringLength2500 = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis sit amet tortor tristique, eleifend justo eget, suscipit ante. Phasellus nec tellus ac tortor consequat viverra id et arcu. Maecenas fermentum congue velit, nec convallis nisl egestas sit amet. Sed eget ligula blandit, ultricies nisl eget, fringilla ex. Cras lacinia tortor et lacus mattis, eget tincidunt erat pharetra. Pellentesque vulputate semper turpis, in congue mi sollicitudin quis. Pellentesque vitae nisl ac ipsum rutrum congue sed nec ligula. Duis convallis molestie accumsan. Integer posuere volutpat pretium. Fusce ac arcu et augue aliquam sollicitudin id ultrices lorem. Proin ac fringilla arcu. Pellentesque consectetur magna ut urna fringilla sagittis. Vivamus suscipit dignissim viverra. Phasellus mauris nisl, sodales vitae odio et, ultricies pulvinar mi.
Proin non cursus mauris, eget porta sapien. Integer semper consequat leo, a pellentesque massa convallis vel. Aenean vitae libero sem. Praesent tincidunt ornare eros. Suspendisse vehicula finibus cursus. Donec accumsan consequat risus, a vestibulum lectus mattis non. Duis tempor mattis sapien ac rhoncus. Nullam bibendum sollicitudin congue.
Nam nec velit in nunc scelerisque egestas a efficitur felis. Donec vestibulum felis at dignissim vehicula. Mauris dapibus mauris quis vehicula pharetra. Vestibulum ac dolor viverra, mattis metus non, ornare turpis. Pellentesque velit lectus, efficitur id tempus at, tincidunt sed ante. Morbi sollicitudin porta rhoncus. Suspendisse aliquet massa eu lorem sagittis imperdiet. Integer vel auctor ipsum. Aenean ultrices lectus in lacus molestie tristique.
Aenean et elit ac elit consequat blandit nec id ipsum. Nunc rutrum massa id urna sollicitudin, at pretium purus tempus. Proin commodo pretium interdum. Phasellus ligula eros, ultrices quis consectetur in, pretium sed mi. Aenean bibendum tempor metus, et laoreet ex ornare ac. Quisque pharetra vitae magna sed euismod. Fusce in justo id arcu hendrerit blandit.
Donec ipsum lacus, facilisis sed ullamcorper id, varius vitae arcu. Cras urna nisl, placerat id ultricies sit amet, varius ut ipsum. Vestibulum quam dui, semper ut egestas a, semper at elit. Curabitur interdum fringilla elit sed commodo. Integer malesuada porttitor urna, ut tempor mi auctor vitae. Cras sit amet nibh eget ligula semper porta. Maecenas egestas consectetur fermentum.
Donec porta finibus urna eu volutpat. Sed ligula nulla, facilisis non varius eget, mattis nec justo. Donec tempus odio ac nullam.";
        }

        [Benchmark]
        public byte[] AsciiEncoding_StringLength12() => ASCII.GetBytes(Constants.StringLength12);

        [Benchmark]
        public byte[] AsciiEncoding_StringLength900() => ASCII.GetBytes(Constants.StringLength900);

        [Benchmark]
        public byte[] AsciiEncoding_StringLength2500() => ASCII.GetBytes(Constants.StringLength2500);

        [Benchmark]
        public byte[] UTF8Encoding_StringLength12() => UTF8.GetBytes(Constants.StringLength12);

        [Benchmark]
        public byte[] UTF8Encoding_StringLength900() => UTF8.GetBytes(Constants.StringLength900);

        [Benchmark]
        public byte[] UTF8Encoding_StringLength2500() => UTF8.GetBytes(Constants.StringLength2500);
    }
}
