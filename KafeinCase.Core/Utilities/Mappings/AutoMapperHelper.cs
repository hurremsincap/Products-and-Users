using AutoMapper;
using System.Collections.Generic;

namespace KafeinCase.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });

            List<T> result = Mapper.Map<List<T>, List<T>>(list);
            return result;
        }
        public static T MapToSameType<T>(T obj)
        {
            Mapper.Initialize(c => { c.CreateMap<T, T>(); });

            T result = Mapper.Map<T, T>(obj);
            return result;
        }

        public static List<K> MapToTypeList<T, K>(List<T> list)
        {
            Mapper.Initialize(c => { c.CreateMap<T, K>(); });

            List<K> result = Mapper.Map<List<T>, List<K>>(list);
            return result;
        }
        public static K MapToType<T, K>(T obj)
        {
            Mapper.Initialize(c => { c.CreateMap<T, K>(); });

            K result = Mapper.Map<T, K>(obj);
            return result;
        }
    }
}
