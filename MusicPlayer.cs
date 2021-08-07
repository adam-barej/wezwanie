using System.Linq;
using System.IO;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Codecs;
using CSCore;

namespace Pablo_C_Sharp
{
    class MusicPlayer
    {
        private ISoundOut _soundOut;
        private IWaveSource _soundSource;

        public MusicPlayer(string filePath)
        {
            try
            {
                _soundSource = CodecFactory.Instance.GetCodec(filePath);
                _soundOut = GetSoundOut();
                _soundOut.Initialize(_soundSource);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Nie odnaleziono nagrania!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Play(float _volume)
        {
            if (_soundOut != null)
            {
                _soundOut.Volume = _volume;
                _soundOut.Play();
            }
        }

        private static ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
            {
                return new WasapiOut
                {
                    Device = GetDevice()
                };
            }
            return new DirectSoundOut();
        }

        public static MMDevice GetDevice()
        {
            using (var mmdeviceEnumerator = new MMDeviceEnumerator())
            {
                using (var mmdeviceCollection = mmdeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                {
                    // This uses the first device, but that isn't what you necessarily want
                    return mmdeviceCollection.First();
                }
            }
        }

    }
}
