﻿// <auto-generated />
using System;
using Intersect.Server.Database.GameData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intersect.Server.Migrations.Game
{
    [DbContext(typeof(GameContext))]
    partial class GameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("Intersect.GameObjects.AnimationBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CompleteSound");

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<string>("Sound");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Animations");
                });

            modelBuilder.Entity("Intersect.GameObjects.ClassBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AttackAnimationId")
                        .HasColumnName("AttackAnimation");

                    b.Property<int>("AttackSpeedModifier");

                    b.Property<int>("AttackSpeedValue");

                    b.Property<string>("AttackSpriteOverride");

                    b.Property<long>("BaseExp");

                    b.Property<int>("BasePoints");

                    b.Property<int>("CritChance");

                    b.Property<double>("CritMultiplier");

                    b.Property<int>("Damage");

                    b.Property<int>("DamageType");

                    b.Property<long>("ExpIncrease");

                    b.Property<string>("ExpOverridesJson")
                        .HasColumnName("ExperienceOverrides");

                    b.Property<string>("Folder");

                    b.Property<bool>("IncreasePercentage");

                    b.Property<string>("JsonBaseStats")
                        .HasColumnName("BaseStats");

                    b.Property<string>("JsonBaseVitals")
                        .HasColumnName("BaseVitals");

                    b.Property<string>("JsonItems")
                        .HasColumnName("Items");

                    b.Property<string>("JsonSpells")
                        .HasColumnName("Spells");

                    b.Property<string>("JsonSprites")
                        .HasColumnName("Sprites");

                    b.Property<bool>("Locked");

                    b.Property<string>("Name");

                    b.Property<int>("PointIncrease");

                    b.Property<string>("RegenJson")
                        .HasColumnName("VitalRegen");

                    b.Property<int>("Scaling");

                    b.Property<int>("ScalingStat");

                    b.Property<int>("SpawnDir");

                    b.Property<Guid>("SpawnMapId")
                        .HasColumnName("SpawnMap");

                    b.Property<int>("SpawnX");

                    b.Property<int>("SpawnY");

                    b.Property<string>("StatIncreaseJson")
                        .HasColumnName("StatIncreases");

                    b.Property<long>("TimeCreated");

                    b.Property<string>("VitalIncreaseJson")
                        .HasColumnName("VitalIncreases");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Intersect.GameObjects.Crafting.CraftBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EventId")
                        .HasColumnName("Event");

                    b.Property<int>("FailureChance");

                    b.Property<string>("Folder");

                    b.Property<string>("IngredientsJson")
                        .HasColumnName("Ingredients");

                    b.Property<Guid>("ItemId");

                    b.Property<int>("ItemLossChance");

                    b.Property<string>("JsonCraftingRequirements")
                        .HasColumnName("CraftingRequirements");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.Property<int>("Time");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Crafts");
                });

            modelBuilder.Entity("Intersect.GameObjects.CraftingTableBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CraftsJson")
                        .HasColumnName("Crafts");

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("CraftingTables");
                });

            modelBuilder.Entity("Intersect.GameObjects.Events.EventBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CommonEvent");

                    b.Property<string>("Folder");

                    b.Property<bool>("Global");

                    b.Property<Guid>("MapId");

                    b.Property<string>("Name");

                    b.Property<string>("PagesJson")
                        .HasColumnName("Pages");

                    b.Property<int>("SpawnX");

                    b.Property<int>("SpawnY");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Intersect.GameObjects.GuildVariableBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<string>("TextId");

                    b.Property<long>("TimeCreated");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("GuildVariables");
                });

            modelBuilder.Entity("Intersect.GameObjects.ItemBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AnimationId")
                        .HasColumnName("Animation");

                    b.Property<Guid>("AttackAnimationId")
                        .HasColumnName("AttackAnimation");

                    b.Property<int>("AttackSpeedModifier");

                    b.Property<int>("AttackSpeedValue");

                    b.Property<int>("BlockAbsorption");

                    b.Property<int>("BlockAmount");

                    b.Property<int>("BlockChance");

                    b.Property<bool>("CanBag");

                    b.Property<bool>("CanBank");

                    b.Property<bool>("CanDrop")
                        .HasColumnName("Bound");

                    b.Property<bool>("CanGuildBank");

                    b.Property<bool>("CanSell");

                    b.Property<bool>("CanTrade");

                    b.Property<string>("CannotUseMessage");

                    b.Property<int>("Cooldown");

                    b.Property<string>("CooldownGroup");

                    b.Property<int>("CritChance");

                    b.Property<double>("CritMultiplier");

                    b.Property<int>("Damage");

                    b.Property<int>("DamageType");

                    b.Property<string>("Description");

                    b.Property<long>("DespawnTime");

                    b.Property<int>("DropChanceOnDeath");

                    b.Property<string>("EffectsJson")
                        .HasColumnName("Effects");

                    b.Property<Guid>("EquipmentAnimationId")
                        .HasColumnName("EquipmentAnimation");

                    b.Property<int>("EquipmentSlot");

                    b.Property<Guid>("EventId")
                        .HasColumnName("Event");

                    b.Property<string>("FemalePaperdoll");

                    b.Property<string>("Folder");

                    b.Property<string>("Icon");

                    b.Property<bool>("IgnoreCooldownReduction");

                    b.Property<bool>("IgnoreGlobalCooldown");

                    b.Property<bool>("IsMainCurrency");

                    b.Property<int>("ItemType");

                    b.Property<string>("JsonColor")
                        .HasColumnName("Color");

                    b.Property<string>("JsonUsageRequirements")
                        .HasColumnName("UsageRequirements");

                    b.Property<string>("MalePaperdoll");

                    b.Property<int>("MaxBankStack");

                    b.Property<int>("MaxInventoryStack");

                    b.Property<string>("Name");

                    b.Property<string>("PercentageStatsJson")
                        .HasColumnName("PercentageStatsGiven");

                    b.Property<string>("PercentageVitalsJson")
                        .HasColumnName("PercentageVitalsGiven");

                    b.Property<int>("Price");

                    b.Property<Guid>("ProjectileId")
                        .HasColumnName("Projectile");

                    b.Property<bool>("QuickCast");

                    b.Property<int>("Rarity");

                    b.Property<int>("Scaling");

                    b.Property<int>("ScalingStat");

                    b.Property<bool>("SingleUse")
                        .HasColumnName("DestroySpell");

                    b.Property<int>("SlotCount");

                    b.Property<int>("Speed");

                    b.Property<Guid>("SpellId")
                        .HasColumnName("Spell");

                    b.Property<bool>("Stackable");

                    b.Property<int>("StatGrowth");

                    b.Property<string>("StatsJson")
                        .HasColumnName("StatsGiven");

                    b.Property<long>("TimeCreated");

                    b.Property<int>("Tool");

                    b.Property<bool>("TwoHanded");

                    b.Property<string>("VitalsJson")
                        .HasColumnName("VitalsGiven");

                    b.Property<string>("VitalsRegenJson")
                        .HasColumnName("VitalsRegen");

                    b.Property<string>("WeaponSpriteOverride");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Intersect.GameObjects.Maps.MapList.MapList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("JsonData")
                        .HasColumnName("JsonData");

                    b.HasKey("Id");

                    b.ToTable("MapFolders");
                });

            modelBuilder.Entity("Intersect.GameObjects.NpcBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aggressive");

                    b.Property<bool>("AttackAllies");

                    b.Property<Guid>("AttackAnimationId")
                        .HasColumnName("AttackAnimation");

                    b.Property<string>("AttackOnSightConditionsJson")
                        .HasColumnName("AttackOnSightConditions");

                    b.Property<int>("AttackSpeedModifier");

                    b.Property<int>("AttackSpeedValue");

                    b.Property<string>("CraftsJson")
                        .HasColumnName("Spells");

                    b.Property<int>("CritChance");

                    b.Property<double>("CritMultiplier");

                    b.Property<int>("Damage");

                    b.Property<int>("DamageType");

                    b.Property<long>("Experience");

                    b.Property<byte>("FleeHealthPercentage");

                    b.Property<bool>("FocusHighestDamageDealer");

                    b.Property<string>("Folder");

                    b.Property<string>("ImmunitiesJson")
                        .HasColumnName("Immunities");

                    b.Property<bool>("IndividualizedLoot");

                    b.Property<string>("JsonAggroList")
                        .HasColumnName("AggroList");

                    b.Property<string>("JsonColor")
                        .HasColumnName("Color");

                    b.Property<string>("JsonDrops")
                        .HasColumnName("Drops");

                    b.Property<string>("JsonMaxVital")
                        .HasColumnName("MaxVital");

                    b.Property<string>("JsonStat")
                        .HasColumnName("Stats");

                    b.Property<int>("Level");

                    b.Property<byte>("Movement");

                    b.Property<string>("Name");

                    b.Property<bool>("NpcVsNpcEnabled");

                    b.Property<Guid>("OnDeathEventId")
                        .HasColumnName("OnDeathEvent");

                    b.Property<Guid>("OnDeathPartyEventId")
                        .HasColumnName("OnDeathPartyEvent");

                    b.Property<string>("PlayerCanAttackConditionsJson")
                        .HasColumnName("PlayerCanAttackConditions");

                    b.Property<string>("PlayerFriendConditionsJson")
                        .HasColumnName("PlayerFriendConditions");

                    b.Property<string>("RegenJson")
                        .HasColumnName("VitalRegen");

                    b.Property<int>("ResetRadius");

                    b.Property<int>("Scaling");

                    b.Property<int>("ScalingStat");

                    b.Property<int>("SightRange");

                    b.Property<int>("SpawnDuration");

                    b.Property<int>("SpellFrequency");

                    b.Property<string>("Sprite");

                    b.Property<bool>("Swarm");

                    b.Property<double>("Tenacity");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Npcs");
                });

            modelBuilder.Entity("Intersect.GameObjects.PlayerVariableBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<string>("TextId");

                    b.Property<long>("TimeCreated");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("PlayerVariables");
                });

            modelBuilder.Entity("Intersect.GameObjects.ProjectileBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AmmoItemId")
                        .HasColumnName("Ammo");

                    b.Property<int>("AmmoRequired");

                    b.Property<string>("AnimationsJson")
                        .HasColumnName("Animations");

                    b.Property<int>("Delay");

                    b.Property<string>("Folder");

                    b.Property<bool>("GrappleHook");

                    b.Property<string>("GrappleHookOptionsJson")
                        .HasColumnName("GrappleHookOptions");

                    b.Property<bool>("IgnoreActiveResources");

                    b.Property<bool>("IgnoreExhaustedResources");

                    b.Property<bool>("IgnoreMapBlocks");

                    b.Property<bool>("IgnoreZDimension");

                    b.Property<int>("Knockback");

                    b.Property<string>("Name");

                    b.Property<bool>("PierceTarget");

                    b.Property<int>("Quantity");

                    b.Property<int>("Range");

                    b.Property<string>("SpawnsJson")
                        .HasColumnName("SpawnLocations");

                    b.Property<int>("Speed");

                    b.Property<Guid>("SpellId")
                        .HasColumnName("Spell");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Projectiles");
                });

            modelBuilder.Entity("Intersect.GameObjects.QuestBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BeforeDescription");

                    b.Property<string>("CompletedCategory");

                    b.Property<bool>("DoNotShowUnlessRequirementsMet");

                    b.Property<string>("EndDescription");

                    b.Property<Guid>("EndEventId")
                        .HasColumnName("EndEvent");

                    b.Property<string>("Folder");

                    b.Property<string>("InProgressCategory");

                    b.Property<string>("InProgressDescription");

                    b.Property<string>("JsonRequirements")
                        .HasColumnName("Requirements");

                    b.Property<bool>("LogAfterComplete");

                    b.Property<bool>("LogBeforeOffer");

                    b.Property<string>("Name");

                    b.Property<int>("OrderValue");

                    b.Property<bool>("Quitable");

                    b.Property<bool>("Repeatable");

                    b.Property<string>("StartDescription");

                    b.Property<Guid>("StartEventId")
                        .HasColumnName("StartEvent");

                    b.Property<string>("TasksJson")
                        .HasColumnName("Tasks");

                    b.Property<long>("TimeCreated");

                    b.Property<string>("UnstartedCategory");

                    b.HasKey("Id");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("Intersect.GameObjects.ResourceBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AnimationId")
                        .HasColumnName("Animation");

                    b.Property<string>("CannotHarvestMessage");

                    b.Property<Guid>("EventId")
                        .HasColumnName("Event");

                    b.Property<string>("Folder");

                    b.Property<string>("JsonDrops")
                        .HasColumnName("Drops");

                    b.Property<string>("JsonHarvestingRequirements")
                        .HasColumnName("HarvestingRequirements");

                    b.Property<int>("MaxHp");

                    b.Property<int>("MinHp");

                    b.Property<string>("Name");

                    b.Property<int>("SpawnDuration");

                    b.Property<long>("TimeCreated");

                    b.Property<int>("Tool");

                    b.Property<int>("VitalRegen");

                    b.Property<bool>("WalkableAfter");

                    b.Property<bool>("WalkableBefore");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Intersect.GameObjects.ServerVariableBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Folder");

                    b.Property<string>("Json")
                        .HasColumnName("Value");

                    b.Property<string>("Name");

                    b.Property<string>("TextId");

                    b.Property<long>("TimeCreated");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("ServerVariables");
                });

            modelBuilder.Entity("Intersect.GameObjects.ShopBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuySound");

                    b.Property<bool>("BuyingWhitelist");

                    b.Property<Guid>("DefaultCurrencyId")
                        .HasColumnName("DefaultCurrency");

                    b.Property<string>("Folder");

                    b.Property<string>("JsonBuyingItems")
                        .HasColumnName("BuyingItems");

                    b.Property<string>("JsonSellingItems")
                        .HasColumnName("SellingItems");

                    b.Property<string>("Name");

                    b.Property<string>("SellSound");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Intersect.GameObjects.SpellBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bound");

                    b.Property<string>("CannotCastMessage");

                    b.Property<Guid>("CastAnimationId")
                        .HasColumnName("CastAnimation");

                    b.Property<int>("CastDuration");

                    b.Property<string>("CastSpriteOverride");

                    b.Property<int>("CooldownDuration");

                    b.Property<string>("CooldownGroup");

                    b.Property<string>("Description");

                    b.Property<Guid>("EventId")
                        .HasColumnName("Event");

                    b.Property<string>("Folder");

                    b.Property<Guid>("HitAnimationId")
                        .HasColumnName("HitAnimation");

                    b.Property<string>("Icon");

                    b.Property<bool>("IgnoreCancelOnMoving");

                    b.Property<bool>("IgnoreCooldownReduction");

                    b.Property<bool>("IgnoreGlobalCooldown");

                    b.Property<string>("JsonCastRequirements")
                        .HasColumnName("CastRequirements");

                    b.Property<string>("Name");

                    b.Property<int>("SpellType");

                    b.Property<Guid>("TickAnimationId")
                        .HasColumnName("TickAnimation");

                    b.Property<long>("TimeCreated");

                    b.Property<string>("VitalCostJson")
                        .HasColumnName("VitalCost");

                    b.HasKey("Id");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("Intersect.GameObjects.TilesetBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("Tilesets");
                });

            modelBuilder.Entity("Intersect.GameObjects.TimeBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DaylightHuesJson")
                        .HasColumnName("DaylightHues");

                    b.Property<int>("RangeInterval");

                    b.Property<float>("Rate");

                    b.Property<bool>("SyncTime");

                    b.HasKey("Id");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("Intersect.GameObjects.UserVariableBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("DataType");

                    b.Property<string>("Folder");

                    b.Property<string>("Name");

                    b.Property<string>("TextId");

                    b.Property<long>("TimeCreated");

                    b.HasKey("Id");

                    b.ToTable("UserVariables");
                });

            modelBuilder.Entity("Intersect.Server.Maps.MapController", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AHue");

                    b.Property<byte[]>("AttributeData")
                        .HasColumnName("Attributes");

                    b.Property<int>("BHue");

                    b.Property<int>("Brightness");

                    b.Property<Guid>("Down");

                    b.Property<string>("EventIdsJson")
                        .HasColumnName("Events");

                    b.Property<string>("Fog");

                    b.Property<int>("FogTransparency");

                    b.Property<int>("FogXSpeed");

                    b.Property<int>("FogYSpeed");

                    b.Property<int>("GHue");

                    b.Property<bool>("HideEquipment");

                    b.Property<bool>("IsIndoors");

                    b.Property<Guid>("Left");

                    b.Property<string>("LightsJson")
                        .HasColumnName("Lights");

                    b.Property<string>("Music");

                    b.Property<string>("Name");

                    b.Property<string>("NpcSpawnsJson")
                        .HasColumnName("NpcSpawns");

                    b.Property<string>("OverlayGraphic");

                    b.Property<string>("Panorama");

                    b.Property<string>("PlayerLightColorJson")
                        .HasColumnName("PlayerLightColor");

                    b.Property<float>("PlayerLightExpand");

                    b.Property<byte>("PlayerLightIntensity");

                    b.Property<int>("PlayerLightSize");

                    b.Property<int>("RHue");

                    b.Property<int>("Revision");

                    b.Property<Guid>("Right");

                    b.Property<string>("Sound");

                    b.Property<byte[]>("TileData");

                    b.Property<long>("TimeCreated");

                    b.Property<Guid>("Up");

                    b.Property<Guid>("WeatherAnimationId")
                        .HasColumnName("WeatherAnimation");

                    b.Property<int>("WeatherIntensity");

                    b.Property<int>("WeatherXSpeed");

                    b.Property<int>("WeatherYSpeed");

                    b.Property<int>("ZoneType");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("Intersect.GameObjects.AnimationBase", b =>
                {
                    b.OwnsOne("Intersect.GameObjects.AnimationLayer", "Lower", b1 =>
                        {
                            b1.Property<Guid>("AnimationBaseId");

                            b1.Property<bool>("AlternateRenderLayer");

                            b1.Property<bool>("DisableRotations");

                            b1.Property<int>("FrameCount");

                            b1.Property<int>("FrameSpeed");

                            b1.Property<string>("Light");

                            b1.Property<int>("LoopCount");

                            b1.Property<string>("Sprite");

                            b1.Property<int>("XFrames");

                            b1.Property<int>("YFrames");

                            b1.ToTable("Animations");

                            b1.HasOne("Intersect.GameObjects.AnimationBase")
                                .WithOne("Lower")
                                .HasForeignKey("Intersect.GameObjects.AnimationLayer", "AnimationBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Intersect.GameObjects.AnimationLayer", "Upper", b1 =>
                        {
                            b1.Property<Guid>("AnimationBaseId");

                            b1.Property<bool>("AlternateRenderLayer");

                            b1.Property<bool>("DisableRotations");

                            b1.Property<int>("FrameCount");

                            b1.Property<int>("FrameSpeed");

                            b1.Property<string>("Light");

                            b1.Property<int>("LoopCount");

                            b1.Property<string>("Sprite");

                            b1.Property<int>("XFrames");

                            b1.Property<int>("YFrames");

                            b1.ToTable("Animations");

                            b1.HasOne("Intersect.GameObjects.AnimationBase")
                                .WithOne("Upper")
                                .HasForeignKey("Intersect.GameObjects.AnimationLayer", "AnimationBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Intersect.GameObjects.ItemBase", b =>
                {
                    b.OwnsOne("Intersect.GameObjects.ConsumableData", "Consumable", b1 =>
                        {
                            b1.Property<Guid>("ItemBaseId");

                            b1.Property<int>("Percentage");

                            b1.Property<byte>("Type");

                            b1.Property<int>("Value");

                            b1.ToTable("Items");

                            b1.HasOne("Intersect.GameObjects.ItemBase")
                                .WithOne("Consumable")
                                .HasForeignKey("Intersect.GameObjects.ConsumableData", "ItemBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Intersect.GameObjects.ResourceBase", b =>
                {
                    b.OwnsOne("Intersect.GameObjects.ResourceState", "Exhausted", b1 =>
                        {
                            b1.Property<Guid>("ResourceBaseId");

                            b1.Property<string>("Graphic");

                            b1.Property<bool>("GraphicFromTileset");

                            b1.Property<int>("Height");

                            b1.Property<bool>("RenderBelowEntities");

                            b1.Property<int>("Width");

                            b1.Property<int>("X");

                            b1.Property<int>("Y");

                            b1.ToTable("Resources");

                            b1.HasOne("Intersect.GameObjects.ResourceBase")
                                .WithOne("Exhausted")
                                .HasForeignKey("Intersect.GameObjects.ResourceState", "ResourceBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Intersect.GameObjects.ResourceState", "Initial", b1 =>
                        {
                            b1.Property<Guid>("ResourceBaseId");

                            b1.Property<string>("Graphic");

                            b1.Property<bool>("GraphicFromTileset");

                            b1.Property<int>("Height");

                            b1.Property<bool>("RenderBelowEntities");

                            b1.Property<int>("Width");

                            b1.Property<int>("X");

                            b1.Property<int>("Y");

                            b1.ToTable("Resources");

                            b1.HasOne("Intersect.GameObjects.ResourceBase")
                                .WithOne("Initial")
                                .HasForeignKey("Intersect.GameObjects.ResourceState", "ResourceBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Intersect.GameObjects.SpellBase", b =>
                {
                    b.OwnsOne("Intersect.GameObjects.SpellCombatData", "Combat", b1 =>
                        {
                            b1.Property<Guid>("SpellBaseId");

                            b1.Property<int>("CastRange");

                            b1.Property<int>("CritChance");

                            b1.Property<double>("CritMultiplier");

                            b1.Property<int>("DamageType");

                            b1.Property<int>("Duration");

                            b1.Property<int>("Effect");

                            b1.Property<bool>("Friendly");

                            b1.Property<int>("HitRadius");

                            b1.Property<bool>("HoTDoT");

                            b1.Property<int>("HotDotInterval");

                            b1.Property<int>("OnHitDuration")
                                .HasColumnName("OnHit");

                            b1.Property<string>("PercentageStatDiffJson")
                                .HasColumnName("PercentageStatDiff");

                            b1.Property<Guid>("ProjectileId")
                                .HasColumnName("Projectile");

                            b1.Property<int>("Scaling");

                            b1.Property<int>("ScalingStat");

                            b1.Property<string>("StatDiffJson")
                                .HasColumnName("StatDiff");

                            b1.Property<int>("TargetType");

                            b1.Property<string>("TransformSprite");

                            b1.Property<int>("TrapDuration")
                                .HasColumnName("Trap");

                            b1.Property<string>("VitalDiffJson")
                                .HasColumnName("VitalDiff");

                            b1.ToTable("Spells");

                            b1.HasOne("Intersect.GameObjects.SpellBase")
                                .WithOne("Combat")
                                .HasForeignKey("Intersect.GameObjects.SpellCombatData", "SpellBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Intersect.GameObjects.SpellDashOpts", "Dash", b1 =>
                        {
                            b1.Property<Guid>("SpellBaseId");

                            b1.Property<bool>("IgnoreActiveResources");

                            b1.Property<bool>("IgnoreInactiveResources");

                            b1.Property<bool>("IgnoreMapBlocks");

                            b1.Property<bool>("IgnoreZDimensionAttributes");

                            b1.ToTable("Spells");

                            b1.HasOne("Intersect.GameObjects.SpellBase")
                                .WithOne("Dash")
                                .HasForeignKey("Intersect.GameObjects.SpellDashOpts", "SpellBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Intersect.GameObjects.SpellReviveOpts", "Revive", b1 =>
                        {
                            b1.Property<Guid>("SpellBaseId");

                            b1.Property<string>("VitalRestoreJson")
                                .HasColumnName("VitalRestore");

                            b1.ToTable("Spells");

                            b1.HasOne("Intersect.GameObjects.SpellBase")
                                .WithOne("Revive")
                                .HasForeignKey("Intersect.GameObjects.SpellReviveOpts", "SpellBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Intersect.GameObjects.SpellWarpData", "Warp", b1 =>
                        {
                            b1.Property<Guid>("SpellBaseId");

                            b1.Property<int>("Dir");

                            b1.Property<Guid>("MapId");

                            b1.Property<int>("X");

                            b1.Property<int>("Y");

                            b1.ToTable("Spells");

                            b1.HasOne("Intersect.GameObjects.SpellBase")
                                .WithOne("Warp")
                                .HasForeignKey("Intersect.GameObjects.SpellWarpData", "SpellBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
