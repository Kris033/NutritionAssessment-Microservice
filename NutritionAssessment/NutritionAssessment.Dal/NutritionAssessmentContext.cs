using Microsoft.EntityFrameworkCore;
using NutritionAssessment.Core.Entities;
using NutritionAssessment.Core.Entities.PassingQuicklyTests;
using NutritionAssessment.Core.Entities.PlanPassingTests;

namespace NutritionAssessment.Dal;

public class NutritionAssessmentContext : DbContext
{
    public NutritionAssessmentContext(DbContextOptions<NutritionAssessmentContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    #region [PlanPassingTests]
    public DbSet<PassingTestChapter> PassingTestChapters { get; set; }

    public DbSet<PassingTestChapterSection> PassingTestChapterSections { get; set; }

    public DbSet<PassingTestChapterSectionOnceDate> PassingTestChapterSectionOnceDates { get; set; }

    public DbSet<PassingTestChapterSectionOnceDateRelation> PassingTestChapterSectionOnceDateRelations { get; set; }

    public DbSet<PassingTestChapterSectionVolume> PassingTestChapterSectionVolume { get; set; }

    public DbSet<PassingTestChapterSectionVolumeRelation> PassingTestChapterSectionVolumeRelations { get; set; }

    public DbSet<PassingTestChapterSectionVolumeType> PassingTestChapterSectionVolumeTypes { get; set; }

    public DbSet<PassingTestDietarySupplementOnceDate> PassingTestDietarySupplementOnceDates { get; set; }

    public DbSet<PassingTestDietarySupplementOnceDateRelation> PassingTestDietarySupplementOnceDateRelations { get; set; }

    public DbSet<PassingTestDietarySupplementTypeVolume> PassingTestDietarySupplementTypeVolumes { get; set; }
    #endregion

    #region [PassingQuicklyTests]
    public DbSet<QuicklyChoiseSection> QuicklyChoiseSections { get; set; }

    public DbSet<QuicklyChoiseSectionTemp> QuicklyChoiseSectionsTemps { get; set; }

    public DbSet<QuicklyChoiseDietarySupplement> QuicklyChoiseDietarySupplements { get; set; }

    public DbSet<QuicklyChoiseDietarySupplementTemp> QuicklyChoiseDietarySupplementsTemps { get; set; }

    public DbSet<QuicklyPassingTestResult> QuicklyPassingTestResults { get; set; }

    public DbSet<QuicklyPassingTestTemp> QuicklyPassingTestTemps { get; set; }
    #endregion

    public DbSet<DietarySupplement> DietarySupplements { get; set; }
    public DbSet<PhysicalActivityLevel> PhysicalActivityLevels { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<PhysicalActivityLevel>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.QuicklyPassingTestResults)
                .WithOne(x => x.PhysicalActivityLevel)
                .HasForeignKey(x => x.PhysicalActivityLevelId);
            x.HasMany(x => x.QuicklyPassingTestTemps)
                .WithOne(x => x.PhysicalActivityLevel)
                .HasForeignKey(x => x.PhysicalActivityLevelId);
        });

        mb.Entity<DietarySupplement>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.OnceDates)
                .WithOne(x => x.DietarySupplement)
                .HasForeignKey(x => x.DietarySupplementId);
            x.HasOne(x => x.TypeVolume)
                .WithMany(x => x.DietarySupplements)
                .HasForeignKey(x => x.TypeVolumeId);
            x.HasOne(x => x.QuicklyChoiseDietarySupplement)
                .WithOne(x => x.DietarySupplement)
                .HasForeignKey<QuicklyChoiseDietarySupplement>(x => x.DietarySupplementId);
            x.HasOne(x => x.QuicklyChoiseDietarySupplement)
                .WithOne(x => x.DietarySupplement)
                .HasForeignKey<QuicklyChoiseDietarySupplement>(x => x.DietarySupplementId);
        });

        #region [PlanPassingTests]
        mb.Entity<PassingTestChapter>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.Sections)
                .WithOne(x => x.Chapter)
                .HasForeignKey(x => x.ChapterId);
        });

        mb.Entity<PassingTestChapterSection>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.OnceDateList)
                .WithOne(x => x.PassingTestChapterSection)
                .HasForeignKey(x => x.PassingTestChapterSectionId);
            x.HasMany(x => x.Volumes)
                .WithOne(x => x.PassingTestChapterSection)
                .HasForeignKey(x => x.PassingTestChapterSectionId);
            x.HasOne(x => x.TypeVolume)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.TypeVolumeId);
            x.HasOne(x => x.Chapter)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ChapterId);
            x.HasOne(x => x.QuicklyChoiseSection)
                .WithOne(x => x.PassingTestChapterSection)
                .HasForeignKey<QuicklyChoiseSection>(x => x.SectionId);
            x.HasOne(x => x.QuicklyChoiseSectionTemp)
                .WithOne(x => x.PassingTestChapterSection)
                .HasForeignKey<QuicklyChoiseSectionTemp>(x => x.SectionId);
        });

        mb.Entity<PassingTestChapterSectionOnceDateRelation>(x =>
        {
            x.HasKey(x => new { x.PassingTestChapterSectionId, x.PassingTestChapterSectionOnceDateId });
            x.HasOne(x => x.PassingTestChapterSection)
                .WithMany(x => x.OnceDateList)
                .HasForeignKey(x => x.PassingTestChapterSectionId);
            x.HasOne(x => x.PassingTestChapterSectionOnceDate)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.PassingTestChapterSectionOnceDateId);
        });

        mb.Entity<PassingTestChapterSectionOnceDate>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.Sections)
                .WithOne(x => x.PassingTestChapterSectionOnceDate)
                .HasForeignKey(x => x.PassingTestChapterSectionOnceDateId);
            x.HasOne(x => x.QuicklyChoiseSection)
                .WithOne(x => x.PassingTestChapterSectionOnceDate)
                .HasForeignKey<QuicklyChoiseSection>(x => x.OnceDateId);
            x.HasOne(x => x.QuicklyChoiseSectionTemp)
                .WithOne(x => x.PassingTestChapterSectionOnceDate)
                .HasForeignKey<QuicklyChoiseSectionTemp>(x => x.OnceDateId);
        });

        mb.Entity<PassingTestChapterSectionVolume>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.Sections)
                .WithOne(x => x.PassingTestChapterSectionVolume)
                .HasForeignKey(x => x.PassingTestChapterSectionVolumeId);
        });

        mb.Entity<PassingTestChapterSectionVolumeRelation>(x =>
        {
            x.HasKey(x => new { x.PassingTestChapterSectionId, x.PassingTestChapterSectionVolumeId });
            x.HasOne(x => x.PassingTestChapterSection)
                .WithMany(x => x.Volumes)
                .HasForeignKey(x => x.PassingTestChapterSectionVolumeId);
            x.HasOne(x => x.PassingTestChapterSectionVolume)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.PassingTestChapterSectionId);
        });

        mb.Entity<PassingTestChapterSectionVolumeType>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.Sections)
                .WithOne(x => x.TypeVolume)
                .HasForeignKey(x => x.TypeVolumeId);
        });

        mb.Entity<PassingTestDietarySupplementOnceDate>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.DietarySupplements)
                .WithOne(x => x.PassingTestDietarySupplementOnceDate)
                .HasForeignKey(x => x.PassingTestDietarySupplementOnceDateId);
            x.HasOne(x => x.QuicklyChoiseDietarySupplementTemp)
                .WithOne(x => x.PassingTestDietarySupplementOnceDate)
                .HasForeignKey<QuicklyChoiseDietarySupplementTemp>(x => x.OnceDateId);
            x.HasOne(x => x.QuicklyChoiseDietarySupplement)
                .WithOne(x => x.PassingTestDietarySupplementOnceDate)
                .HasForeignKey<QuicklyChoiseDietarySupplement>(x => x.OnceDateId);
        });

        mb.Entity<PassingTestDietarySupplementOnceDateRelation>(x =>
        {
            x.HasKey(x => new { x.DietarySupplementId, x.PassingTestDietarySupplementOnceDateId });
            x.HasOne(x => x.DietarySupplement)
                .WithMany(x => x.OnceDates)
                .HasForeignKey(x => x.DietarySupplementId);
            x.HasOne(x => x.PassingTestDietarySupplementOnceDate)
                .WithMany(x => x.DietarySupplements)
                .HasForeignKey(x => x.PassingTestDietarySupplementOnceDateId);
        });

        mb.Entity<PassingTestDietarySupplementTypeVolume>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.DietarySupplements)
                .WithOne(x => x.TypeVolume)
                .HasForeignKey(x => x.TypeVolumeId);
        });
        #endregion

        #region [PassingQuicklyTests]
        mb.Entity<QuicklyChoiseDietarySupplement>(x =>
        {
            x.HasKey(x => new { x.DietarySupplementId, x.OnceDateId });
            x.HasOne(x => x.DietarySupplement)
                .WithOne(x => x.QuicklyChoiseDietarySupplement)
                .HasForeignKey<QuicklyChoiseDietarySupplement>(x => x.DietarySupplementId);
            x.HasOne(x => x.PassingTestDietarySupplementOnceDate)
                .WithOne(x => x.QuicklyChoiseDietarySupplement)
                .HasForeignKey<QuicklyChoiseDietarySupplement>(x => x.OnceDateId);
        });

        mb.Entity<QuicklyChoiseDietarySupplementTemp>(x =>
        {
            x.HasKey(x => new { x.DietarySupplementId, x.OnceDateId });
            x.HasOne(x => x.DietarySupplement)
                .WithOne(x => x.QuicklyChoiseDietarySupplementTemp)
                .HasForeignKey<QuicklyChoiseDietarySupplementTemp>(x => x.DietarySupplementId);
            x.HasOne(x => x.PassingTestDietarySupplementOnceDate)
                .WithOne(x => x.QuicklyChoiseDietarySupplementTemp)
                .HasForeignKey<QuicklyChoiseDietarySupplementTemp>(x => x.OnceDateId);
        });

        mb.Entity<QuicklyChoiseSection>(x =>
        {
            x.HasKey(x => new { x.SectionId, x.OnceDateId });
            x.HasOne(x => x.PassingTestChapterSection)
                .WithOne(x => x.QuicklyChoiseSection)
                .HasForeignKey<QuicklyChoiseSection>(x => x.SectionId);
            x.HasOne(x => x.PassingTestChapterSectionOnceDate)
                .WithOne(x => x.QuicklyChoiseSection)
                .HasForeignKey<QuicklyChoiseSection>(x => x.OnceDateId);
        });

        mb.Entity<QuicklyChoiseSectionTemp>(x =>
        {
            x.HasKey(x => new { x.SectionId, x.OnceDateId });
            x.HasOne(x => x.PassingTestChapterSection)
                .WithOne(x => x.QuicklyChoiseSectionTemp)
                .HasForeignKey<QuicklyChoiseSectionTemp>(x => x.SectionId);
            x.HasOne(x => x.PassingTestChapterSectionOnceDate)
                .WithOne(x => x.QuicklyChoiseSectionTemp)
                .HasForeignKey<QuicklyChoiseSectionTemp>(x => x.OnceDateId);
        });

        mb.Entity<QuicklyPassingTestResult>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasOne(x => x.PhysicalActivityLevel)
                .WithMany(x => x.QuicklyPassingTestResults)
                .HasForeignKey(x => x.PhysicalActivityLevelId);
            x.HasMany(x => x.ChoiseSections)
                .WithOne(x => x.QuicklyPassingTestResult)
                .HasForeignKey(x => x.QuicklyPassingTestResultId);
            x.HasMany(x => x.QuicklyChoiseDietarySupplements)
                .WithOne(x => x.QuicklyPassingTestResult)
                .HasForeignKey(x => x.QuicklyPassingTestResultId);
        });

        mb.Entity<QuicklyPassingTestTemp>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasOne(x => x.PhysicalActivityLevel)
                .WithMany(x => x.QuicklyPassingTestTemps)
                .HasForeignKey(x => x.PhysicalActivityLevelId);
            x.HasMany(x => x.QuicklyChoiseDietarySupplements)
                .WithOne(x => x.QuicklyPassingTestTemp)
                .HasForeignKey(x => x.QuicklyPassingTestTempId);
            x.HasMany(x => x.ChoiseSections)
                .WithOne(x => x.QuicklyPassingTestTemp)
                .HasForeignKey(x => x.QuicklyPassingTestTempId);
        });
        #endregion
    }
}