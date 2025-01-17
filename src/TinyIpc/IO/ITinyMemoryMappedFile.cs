using System;

namespace TinyIpc.IO
{
	public interface ITinyMemoryMappedFile
	{
		/// <summary>
		/// Called whenever the file is written to
		/// </summary>
		event EventHandler FileUpdated;

		/// <summary>
		/// The maximum amount of data that can be written to the file
		/// </summary>
		long MaxFileSize { get; }

		/// <summary>
		/// Gets the file size
		/// </summary>
		/// <returns>File size</returns>
		int GetFileSize();

		/// <summary>
		/// Reads the content of the memory mapped file with a read lock in place.
		/// </summary>
		/// <returns>File content</returns>
		byte[] Read();

		/// <summary>
		/// Replaces the content of the memory mapped file with a write lock in place.
		/// </summary>
		void Write(byte[] data);

		/// <summary>
		/// Reads and then replaces the content of the memory mapped file with a write lock in place.
		/// </summary>
		void ReadWrite(Func<byte[], byte[]> updateFunc);
	}
}
