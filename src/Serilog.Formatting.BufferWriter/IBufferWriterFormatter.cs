using System.Buffers;
using System.Text;
using Serilog.Events;

namespace Serilog.Formatting;


/// <summary>
/// Formats log events into <see cref="IBufferWriter{Byte}"/>
/// </summary>
public interface IBufferWriterFormatter
{
  /// <summary>
  /// Format the log event into the output.
  /// </summary>
  /// <param name="logEvent">The event to format.</param>
  /// <param name="buffer">The output.</param>
  void Format(LogEvent logEvent, IBufferWriter<byte> buffer);

  /// <summary>
  /// Encoding used by this <see cref="IBufferWriterFormatter"/> implementation.
  /// </summary>
  Encoding Encoding { get; }
}
