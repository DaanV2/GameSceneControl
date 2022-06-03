using System.Diagnostics.CodeAnalysis;
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
        public static T ById<T>([DisallowNull] this ICollection<T> items, [DisallowNull] String ID)
            where T : class, IIdentifiable {

            foreach (T item in items) {
                if (item.ID == ID) return item;
            }

            return null;
        }
    }
}
