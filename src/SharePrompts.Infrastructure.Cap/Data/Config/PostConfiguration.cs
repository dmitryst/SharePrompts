using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharePrompts.Core.Cap.PostAggregate;

namespace SharePrompts.Infrastructure.Cap.Data.Config;

internal class PostConfiguration : IEntityTypeConfiguration<Post>
{
  public void Configure(EntityTypeBuilder<Post> builder)
  {
    builder.Property(p => p.Title)
      .HasMaxLength(DataSchemaConstants.MAX_POST_TITLE_LENGTH)
      .IsRequired();

    builder.Property(p => p.Text)
      .HasMaxLength(DataSchemaConstants.MAX_POST_TEXT_LENGTH)
      .IsRequired();

    builder.Property(p => p.Tag)
      .HasMaxLength(DataSchemaConstants.MAX_POST_TAG_LENGTH);
  }
}
