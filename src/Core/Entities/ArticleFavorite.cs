﻿using System.ComponentModel.DataAnnotations;

namespace Realworlddotnet.Core.Entities;

public class ArticleFavorite(string username, Guid articleId)
{
    [MaxLength(100)]
    public string Username { get; set; } = username;

    public Guid ArticleId { get; set; } = articleId;

    public User User { get; set; } = null!;

    public Article Article { get; set; } = null!;
}
