﻿namespace FIHS.Extensions;

public static class PaginationExtension
{
    public static  (IEnumerable<T> result, int nextPage) Paginate<T>(this IEnumerable<T> source, int offset, int limit) where T : class
    {
        if (offset <= 0)
            offset = 1;

        if (limit <= 0)
            limit = 10;

        var total = source.Count();

        var numberOfPages = (int)Math.Ceiling((decimal)total / limit);
        int nextPage = offset < numberOfPages ? offset + 1 : 0;
        var result = source.Skip((offset - 1) * limit).Take(limit).ToList();

        return (result, nextPage);
    }
}

