﻿/**
 * GWebSearcher.cs
 *
 * Copyright (C) 2008,  iron9light
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
using System.Net;
[assembly: CLSCompliant(true)]

namespace Google.API.Search
{
    public static class GWebSearcher
    {
        internal static SearchData<GWebSearchResult> Search(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            GWebSearchRequest request = new GWebSearchRequest(text);

            WebRequest webRequest = request.GetWebRequest();

            SearchData<GWebSearchResult> responseData;
            try
            {
                responseData = RequestUtility.GetResponseData<SearchData<GWebSearchResult>>(webRequest);
            }
            catch (GoogleAPIException ex)
            {
                throw new SearchException(string.Format("request:\"{0}\"", request), ex);
            }
            return responseData;
        }

        internal static SearchData<GWebSearchResult> Search(string text, int start)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            GWebSearchRequest request = new GWebSearchRequest(text, start);

            WebRequest webRequest = request.GetWebRequest();

            SearchData<GWebSearchResult> responseData;
            try
            {
                responseData = RequestUtility.GetResponseData<SearchData<GWebSearchResult>>(webRequest);
            }
            catch (GoogleAPIException ex)
            {
                throw new SearchException(string.Format("request:\"{0}\"", request), ex);
            }
            return responseData;
        }

        internal static SearchData<GWebSearchResult> Search(string text, int start, ResultSizeEnum resultSize)
        {
            if(text == null)
            {
                throw new ArgumentNullException("text");
            }

            GWebSearchRequest request = new GWebSearchRequest(text, start, resultSize);

            WebRequest webRequest = request.GetWebRequest();

            SearchData<GWebSearchResult> responseData;
            try
            {
                responseData = RequestUtility.GetResponseData<SearchData<GWebSearchResult>>(webRequest);
            }
            catch (GoogleAPIException ex)
            {
                throw new SearchException(string.Format("request:\"{0}\"", request), ex);
            }
            return responseData;
        }
    }
}
