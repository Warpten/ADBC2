﻿/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 16/10/2014
 * Time: 19:00
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ADBC2.Structures.Version15595
{
    [DbFileInfo(15595, "SpellVisual.dbc")]
    public sealed class SpellVisualEntry
    {
        public uint Id;
        public uint PrecastKit;
        public uint CastingKit;
        public uint ImpactKit;
        public uint StateKit;
        public uint StateDoneKit;
        public uint ChannelKit;
        public int HasMissile;
        public uint MissileModel;
        public uint MissilePathType;
        public uint MissileDestinationAttachment;
        public uint MissileSound;
        public uint AnimEventSoundID;
        public uint Flags;
        public uint CasterImpactKit;
        public uint TargetImpactKit;
        public int MissileAttachment;
        public uint MissileFollowGroundHeight;
        public uint MissileFollowGroundDropSpeed;
        public uint MissileFollowGroundApprach;
        public uint MissileFollowGroundFlags;
        public uint MissileMotionId;
        public uint MissileTargetingKit;
        public uint InstantAreaKit;
        public uint ImpactAreaKit;
        public uint PersistentAreaKit;
        public float MissileCastOffsetX;
        public float MissileCastOffsetY;
        public float MissileCastOffsetZ;
        public float MissileImpactOffsetX;
        public float MissileImpactOffsetY;
        public float MissileImpactOffsetZ;
        public uint Unknown;
    }
}
