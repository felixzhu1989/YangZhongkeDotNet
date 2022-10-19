﻿using SubtitlesParser.Classes.Parsers;

namespace Listening.Domain.Subtitles
{
    //解析字幕工厂模式（根据不同类型SubtitleType，提供不同的解析类），用来简化调用
    static class SubtitleParserFactory
    {
        private static List<ISubtitleParser> parsers = new();
        static SubtitleParserFactory()
        {
            //扫描本程序集中的所有实现了ISubtitleParser接口的类
            var parserTypes = typeof(SubtitleParserFactory).Assembly.GetTypes()
                .Where(t => typeof(ISubtitlesParser).IsAssignableFrom(t) && !t.IsAbstract);
            //创建这些对象，添加到parsers
            foreach (var parserType in parserTypes)
            {
                ISubtitleParser parser = (ISubtitleParser)Activator.CreateInstance(parserType);
                parsers.Add(parser);
            }
        }
        public static ISubtitleParser? GetParser(string typeName)
        {
            //遍历所有解析器，挨个问他们“能解析这个格式吗”，碰到一个能解析的，就会把解析器返回
            foreach (var parser in parsers)
            {
                if (parser.Accept(typeName)) return parser;
            }
            return null;
        }
    }
}
