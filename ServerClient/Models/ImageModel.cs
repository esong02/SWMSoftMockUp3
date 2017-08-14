namespace ServerClient.Models
{
    /// <summary>
    ///     image model at server side, only get method, without any set method.
    /// </summary>
    public class ImageModel
    {
        /// <summary>
        ///     file name
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     file bytes
        /// </summary>
        public byte[] Bytes { get; }

        /// <summary>
        ///     component type, true for lid components, false for other components
        /// </summary>
        public bool ComponentType { get; }

        /// <summary>
        ///     picture type, true for mantenances, false for inspections
        /// </summary>
        public bool PictureType { get; }

        /// <summary>
        ///     task id, according to picture type, true for mantenance id, false for inspection id
        /// </summary>
        public int TaskID { get; }

        /// <summary>
        ///     component id, according to component type, true for lidcomponent id, false for other component id.
        /// </summary>
        public int ComponentID { get; }
    }
}