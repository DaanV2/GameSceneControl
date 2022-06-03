using System.Runtime.CompilerServices;

namespace GameSceneControl {
    ///DOLATER <summary>add description for class: IdentifiableExtension</summary>
    public static partial class IdentifiableExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static T ById<T>(this ICollection<T> items, Guid ID)
            where T : class, IIdentifiable {

            foreach (var item in items) {
                if (item.ID == ID) return item;
            }

            return null;
        }
    }
}
